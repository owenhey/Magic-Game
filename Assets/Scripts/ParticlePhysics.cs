using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePhysics : MonoBehaviour {

	private float gravMultiplier;
	private float spellLifetime;
	private float spellDamage;
	private float spellSpeed;
	private Transform spellCastHotSpot;
	private GameObject spellExplosion;
	private Rigidbody rb;


	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody>();
		rb.AddForce(gameObject.transform.forward * spellSpeed * 100);
		StartCoroutine("Death");
		Destroy(gameObject, spellLifetime);
	}
	
	// Update is called once per frame
	void Update () {
		if(gravMultiplier != 0){
			rb.AddForce(100*Physics.gravity * gravMultiplier * Time.deltaTime);
		}
	}

	IEnumerator Death(){
		if(spellLifetime > 1.5f){
			yield return new WaitForSeconds(spellLifetime - 1.5f);
			gameObject.GetComponent<ParticleSystem>().Stop();
		}
		else{
			gameObject.GetComponent<ParticleSystem>().Stop();
		}
	}

	public void SetUp(float g, float sL, float sD, float sS, GameObject sE){
		gravMultiplier = g; spellLifetime = sL; spellDamage = sD; spellSpeed = sS; spellExplosion = sE;
	}

	void OnTriggerEnter(Collider other){
		if(!other.isTrigger){
			CharacterHealth CH;
			if(other.gameObject.GetComponent<Transform>().parent){
				CH = other.gameObject.GetComponent<Transform>().parent.gameObject.GetComponent<CharacterHealth>();
				if(CH != null){
					CH.currentHealth = CH.currentHealth - spellDamage;
				}
			}
			if(spellExplosion){
				Destroy(Instantiate(spellExplosion, transform.position - transform.forward * 2, Quaternion.identity), 2);
			}
			gameObject.GetComponent<ParticleSystem>().Stop();
			Destroy(gameObject.GetComponent<SphereCollider>());
			if(gameObject.transform.childCount > 0){
				Destroy(gameObject.transform.GetChild(0).gameObject);
			}
		}
	}
}
