using System.Collections;
using UnityEditor.Tilemaps;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Настройки спавна")]
    [SerializeField] private GameObject[] _enemyPrefab;
    
    [Tooltip("Задержка перед началом спавна (в секундах)")]
    [SerializeField] private float _startDelay = 2.0f;
    
    [Tooltip("Интервал между волнами спавна (в секундах)")]
    [SerializeField] private float _spawnInterval = 5.0f;
    
    [Tooltip("Количество врагов, появляющихся одновременно")]
    [SerializeField] private int _enemiesPerWave = 3;

    private bool _gameNow = true;
    private void OnEnable()
    {
        TimerScript.GameOver +=GameOver;
    }

    private void OnDisable()
    {
        TimerScript.GameOver -=GameOver;
    }

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
        yield return new WaitForSeconds(Random.Range(_startDelay, _startDelay + 3f));

        while (_gameNow)
        {
            // Спавним сразу несколько врагов за один раз
            for (int i = 0; i < Random.Range(1, _enemiesPerWave); i++)
            {
                // Для теста они спавнятся в одной точке. 
                // При желании сюда можно добавить случайное смещение Random.Range
                Instantiate(_enemyPrefab[Random.Range(0, _enemyPrefab.Length)], transform.position, Quaternion.identity);
            }
            
            // Ожидание перед следующей волной
            yield return new WaitForSeconds(Random.Range(_spawnInterval - 2f, _spawnInterval + 2f));
        }
    }

    void GameOver()
    {
        _gameNow = false;
    }
    
}
