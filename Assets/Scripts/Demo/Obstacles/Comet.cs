using UnityEngine;

public class Comet : MonoBehaviour
{
    [SerializeField] float _maxSpeedX = 5f;
    [SerializeField] float _minSpeedX = 20f;
    [SerializeField] float _minSpeedY = 5f;
    [SerializeField] float _maxSpeedY = 20f;
    float _speedX;
    float _speedY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _speedX = Random.Range(_maxSpeedX, _maxSpeedX);
        _speedY = Random.Range(_minSpeedY, _maxSpeedY);
        if (transform.position.x > 0)
            _speedX *= -1;
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + _speedX*Time.deltaTime, transform.position.y - _speedY * Time.deltaTime); 
    }
}
