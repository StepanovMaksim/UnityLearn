using UnityEngine;

public class PoisonDamageToEnemy : MonoBehaviour
{
    public int damageAmount = 1;
    public float damageInterval = 1.0f;
    
    private float nextDamageTime;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (Time.time >= nextDamageTime)
            {
                var enemyHealth = other.GetComponent<HealPlayerScript>(); 
                
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(damageAmount); 
                    nextDamageTime = Time.time + damageInterval;
                }
            }
        }
    }
}