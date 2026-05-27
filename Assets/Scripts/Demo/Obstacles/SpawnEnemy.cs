using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject[] _prefubEnemy;
    int _count;
    
    // Start is called before the first frame update
    void Start()
    {
        _count = Random.Range(0, _prefubEnemy.Length+4);
        for (int i = 0; i < _prefubEnemy.Length; i++)
        {
            if (_count == i)
                Instantiate(_prefubEnemy[i], transform.position, Quaternion.identity);
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
