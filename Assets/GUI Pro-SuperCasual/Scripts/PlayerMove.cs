using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController _controller;
    [SerializeField] float _speed;
    [SerializeField] float _gravity = 9.81f;
    [SerializeField] float _jumpHeight = 3f;
    private bool _isGrounded;
    Vector3 _velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    
    void Update()
    {
        _isGrounded = _controller.isGrounded;
        if (_isGrounded && _velocity.y < 0)
            _velocity.y = -2f;
        if (Input.GetKeyDown(KeyCode.Space)&& _isGrounded)
                                          _velocity.y = Mathf.Sqrt(_jumpHeight * -2f * _gravity);
        _velocity.y -= _gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime); 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movement = transform.right * x + transform.forward * z;
        _controller.Move(movement * _speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            _speed *=3 ;
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
            _speed /= 3 ;
        
    }
}
