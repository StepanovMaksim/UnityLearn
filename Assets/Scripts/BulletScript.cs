using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] GameObject _bulletEffect;
    [SerializeField] float _timeDestroy=5f;
    [SerializeField] int _damage = 1;
    Rigidbody _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(transform.up * _speed, ForceMode.Impulse);
        Destroy(gameObject, _timeDestroy);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(_bulletEffect, transform.position, transform.rotation);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<HealPlayerScript>().TakeDamage(_damage);
        }
        // Destroy(gameObject);
    }
}
        
    
    
    
