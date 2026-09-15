using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    [Header("Настройки спавна")]
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _spawnInterval = 20f;
    float startInterval;
    void Start()
    {
        //StartCoroutine(SpawnRoutine());
        startInterval = _spawnInterval;
    }

    void Update()
    {
        if (_spawnInterval > 0)
        {
            _spawnInterval -= Time.deltaTime;
        }
        else
        {
            _spawnInterval = startInterval;
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        }
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnInterval);
            
            if (_enemyPrefab != null)
            {
                Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("Пожалуйста, перетащите префаб врага в поле Enemy Prefab!");
            }
        }
    }
}
