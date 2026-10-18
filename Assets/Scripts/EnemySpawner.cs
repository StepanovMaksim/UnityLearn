using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Настройки спавна")]
    [SerializeField] private GameObject _enemyPrefab;
    
    [Tooltip("Задержка перед началом спавна (в секундах)")]
    [SerializeField] private float _startDelay = 2.0f;
    
    [Tooltip("Интервал между волнами спавна (в секундах)")]
    [SerializeField] private float _spawnInterval = 5.0f;
    
    [Tooltip("Количество врагов, появляющихся одновременно")]
    [SerializeField] private int _enemiesPerWave = 3;

    private void Start()
    {
        if (_enemyPrefab != null)
        {
            StartCoroutine(SpawnRoutine());
        }
        else
        {
            Debug.LogWarning("Пожалуйста, перетащите префаб врага в поле Enemy Prefab!");
        }
    }

    private IEnumerator SpawnRoutine()
    {
        // Ожидание перед самым первым спавном после начала игры
        yield return new WaitForSeconds(_startDelay);

        while (true)
        {
            // Спавним сразу несколько врагов за один раз
            for (int i = 0; i < _enemiesPerWave; i++)
            {
                // Для теста они спавнятся в одной точке. 
                // При желании сюда можно добавить случайное смещение Random.Range
                Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            }

            // Ожидание перед следующей волной
            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
