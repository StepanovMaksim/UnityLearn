using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damageAmount = 5;         // Урон за один удар
    public float attackCooldown = 1.0f;  // Задержка между ударами (в секундах)
    private float nextAttackTime = 0f;

    // Метод срабатывает, когда враг касается другого коллайдера
    private void OnCollisionStay(Collision collision)
    {
        // Проверяем, что коснулись именно игрока по его тегу
        if (collision.gameObject.CompareTag("Player"))
        {
            // Проверяем, прошло ли время перезарядки атаки
            if (Time.time >= nextAttackTime)
            {
                // Ищем компонент здоровья на игроке
                HealPlayer healPlayer = collision.gameObject.GetComponent<HealPlayer>();
                
                if (healPlayer != null)
                {
                    healPlayer.TakeDamage(damageAmount);
                    // Задаем время, когда будет возможен следующий удар
                    nextAttackTime = Time.time + attackCooldown;
                }
            }
        }
    }
}
