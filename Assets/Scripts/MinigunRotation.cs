using UnityEngine;

public class MinigunRotation : MonoBehaviour
{
    [Header("Настройки вращения")]
    [SerializeField] private Transform _rotatingBarrel; // Сюда перетащить вращающуюся часть ствола
    [SerializeField] private float _maxRotationSpeed = 1000f; // Максимальная скорость вращения
    [SerializeField] private float _acceleration = 500f; // Скорость разгона стволов
    [SerializeField] private float _deceleration = 400f; // Скорость торможения стволов

    private float _currentSpeed = 0f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _currentSpeed = Mathf.MoveTowards(_currentSpeed, _maxRotationSpeed, _acceleration * Time.deltaTime);
        }
        else
        {
            _currentSpeed = Mathf.MoveTowards(_currentSpeed, 0f, _deceleration * Time.deltaTime);
        }
        
        if (_currentSpeed > 0f && _rotatingBarrel != null)
        {
            _rotatingBarrel.Rotate(Vector3.forward, _currentSpeed * Time.deltaTime);
        }
    }
} 