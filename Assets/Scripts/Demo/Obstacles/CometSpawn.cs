using UnityEngine;

public class CometSpawn : MonoBehaviour
{
    [SerializeField] GameObject _comet;
    [SerializeField] float _minTime = 1f;
    [SerializeField] float _maxTime = 10f;
    float _timeSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _timeSpawn = Random.Range(_minTime, _maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        _timeSpawn -= Time.deltaTime;
        if (_timeSpawn < 0)
        {
            _timeSpawn = Random.Range(_minTime, _maxTime);
            Instantiate(_comet, transform.position, Quaternion.identity);
        }
    }
}
