using UnityEngine;

public class DamageObstacle : MonoBehaviour
{
    [SerializeField] int damageAmount = 5;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<HealPlayerScript>().TakeDamage(damageAmount);
            collision.gameObject.GetComponent<CharacterController>().Move(Vector3.back*1f);
          //  collision.gameObject.transform.position = collision.gameObject.transform.forward - new Vector3(1f, 1f, 1f);  
        }
    }
}
