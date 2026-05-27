using UnityEngine;

public class RandomObstacles : MonoBehaviour
{
    [SerializeField] GameObject _nextSpawn;
    [SerializeField] GameObject[] _obstacles;
    [SerializeField] float _rightMinX;
    [SerializeField] float _rightMaxX;
    [SerializeField] float _rightMinY;
    [SerializeField] float _rightMaxY;
    [SerializeField] float _topMinX;
    [SerializeField] float _topMaxX;
    [SerializeField] float _topMinY;
    [SerializeField] float _topMaxY;
    [SerializeField] float _maxRightX;
    [SerializeField] float _maxTopY;
    [SerializeField] float _distanceOfRocket;
    int _objNow;
    Transform _rocket;
    bool _objRight = true;
    bool _objTop;

    float randomRightX;
    float randomRightY;
    float randomTopX;
    float randomTopY;
    private void Start()
    {
        _rocket = GameObject.Find("Rocket").GetComponent<Transform>();
        if (transform.position.x > _maxRightX )
            _objRight = true;
        else if (transform.position.y < 15)
            _objRight = false;
        randomRightX = Random.Range(_rightMinX, _rightMaxX);
        randomRightY = Random.Range(_rightMinY, _rightMaxY);
        randomTopX = Random.Range(_topMinX, _topMaxX);
        randomTopY = Random.Range(_topMinY, _topMaxY);
    }

    private void Update()
    {

        if (transform.position.y - (_rocket.position.y + _distanceOfRocket) < 0 && _rocket != null)
        {
            
            if (!_objRight)
            {
                Vector2 posRight = new Vector2(transform.position.x + randomRightX, transform.position.y + randomRightY);
                _objNow = Random.Range(0, _obstacles.Length);
                Instantiate(_obstacles[_objNow], posRight, Quaternion.identity, transform);
                Instantiate(_nextSpawn, posRight, Quaternion.identity);
                _objRight = true;
            }
            if (!_objTop)
            {
                Vector2 posTop = new Vector2(transform.position.x + randomTopX, transform.position.y + randomTopY);
                _objNow = Random.Range(0, _obstacles.Length);
                Instantiate(_obstacles[_objNow], posTop, Quaternion.identity, transform);
                Instantiate(_nextSpawn, posTop, Quaternion.identity);
                _objTop = true;
            }
           
        }

    }


}
