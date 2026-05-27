using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    [SerializeField] GameObject _prefubZoneEnemy;
    [SerializeField] Transform _newEnemyPosition;
    [SerializeField] float _timeSpawn;
    float _timeGame;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Rocket")
            Instantiate(_prefubZoneEnemy, _newEnemyPosition.position, Quaternion.identity);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*_timeGame += Time.deltaTime;
        if (_timeGame > _timeSpawn)
        {
            _timeGame = 0;
            Instantiate(_prefubZoneEnemy, _newEnemyPosition.position, Quaternion.identity);
        }*/
    }
}
