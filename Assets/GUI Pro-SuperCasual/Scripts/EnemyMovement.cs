using UnityEngine;
using UnityEngine.AI; // Этот пункт обязателен, чтобы скрипт умел управлять навигацией

public class EnemyMovement : MonoBehaviour
{
    private Transform playerTransform;
    private NavMeshAgent agent;

    void Start()
    {
        // Ищем игрока на всей сцене по его тегу
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            // Сообщение на случай, если вы забыли поставить тег игроку
            Debug.LogError("Враг не может найти игрока! Проверьте, что у объекта Player в инспекторе сверху установлен Tag -> 'Player'.");
        }

        // Получаем компонент NavMeshAgent, который мы добавим на капсулу
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Если игрок найден и компонент навигации активен, приказываем врагу идти к игроку
        if (playerTransform != null && agent != null)
        {
            agent.SetDestination(playerTransform.position);
        }
    }
}
