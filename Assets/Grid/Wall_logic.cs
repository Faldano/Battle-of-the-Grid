using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_logic : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 2;
    int currentHealth;
    
    void Start()
    {
        currentHealth = maxHealth;    
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("UserCannon") || other.gameObject.CompareTag("EnemyCannon"))
        {
            TakeDamage();
        }
        Debug.Log("Wall Damaged!");
    }

    void TakeDamage()
    {
        currentHealth--;

        if(currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
