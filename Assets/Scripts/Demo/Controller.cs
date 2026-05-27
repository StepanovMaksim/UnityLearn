using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float _maxSpeed;
    [SerializeField] float _speedRotate;
    [SerializeField] float _speedDelta;
    Transform _camera;
    Rigidbody2D _rb;
    float _speed;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _camera = GameObject.Find("Camera").GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        { 
            if (_speed < _maxSpeed)
                _speed += _speedDelta * Time.deltaTime;

        }
        if (Input.GetMouseButtonUp(0))
        {
            _speed = _maxSpeed / 10f;
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            _rb.AddForce(transform.up * _speed);
            if (Camera.main.ScreenToWorldPoint(mousePos).x - _camera.position.x <= 0)
            {
                transform.Rotate(0f, 0f, _speedRotate, Space.World);
            }
            else
                transform.Rotate(0f, 0f, -_speedRotate, Space.World);

            
        }

    }
}
