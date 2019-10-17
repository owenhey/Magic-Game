using UnityEngine;

public class CharacterHealth : MonoBehaviour {
	public float currentHealth = 100;
	public float maxHealth = 100;
	public float healthRegen = .1f;

	void FixedUpdate(){
		if(currentHealth <= 0){
			Die();
			return;
		}
		if(currentHealth <= maxHealth){
			currentHealth += healthRegen;
			if(currentHealth > maxHealth){
				currentHealth = maxHealth;
			}
		}
	}

	void Die(){
		
	}
}
