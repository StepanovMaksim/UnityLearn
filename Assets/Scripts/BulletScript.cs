using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float _speed;

    Rigidbody _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(transform.up * _speed, ForceMode.Impulse);
        
    }
}
        
    
    
    
