using System.Collections;
using UnityEngine;

public class HealingPlate : MonoBehaviour
{
    public int healAmount = 2; // Сколько хитпоинтов восстанавливать
    public float healInterval = 1f; // Интервал лечения в секундах

    private Coroutine healingCoroutine;

    // Срабатывает, когда объект входит в зону триггера
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что на пластину наступил именно игрок
        if (other.CompareTag("Player"))
        {
            // Получаем скрипт здоровья игрока (исправлено на HealPlayerScript)
            HealPlayerScript playerHealth = other.GetComponent<HealPlayerScript>();

            if (playerHealth != null)
            {
                // Запускаем периодическое лечение
                healingCoroutine = StartCoroutine(HealOverTime(playerHealth));
            }
        }
    }

    // Срабатывает, когда объект покидает зону триггера
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Если игрок сошел с пластины, останавливаем лечение
            if (healingCoroutine != null)
            {
                StopCoroutine(healingCoroutine);
                healingCoroutine = null;
            }
        }
    }

    // Корутина для ежесекундного лечения (исправлено на HealPlayerScript)
    private IEnumerator HealOverTime(HealPlayerScript health)
    {
        while (true)
        {
            // Внимание: если метод лечения в вашем HealPlayerScript называется иначе,
            // например AddHealth, то замените .Heal на .AddHealth
       //     health.Heal(healAmount); 
            yield return new WaitForSeconds(healInterval);
        }
    }
}
