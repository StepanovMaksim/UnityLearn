using UnityEngine;

public class GunScript2 : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _bulletSpawn;
    [SerializeField] float _fireRate = 0.5f;   
    [SerializeField] float _bulletSpeed = 15f; 

    private float _nextFireTime = 0f;          

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= _nextFireTime)
        {
            Shoot();
            _nextFireTime = Time.time + _fireRate; 
        }
    }

    void Shoot()
    {
        GameObject newBullet = Instantiate(_bullet, _bulletSpawn.position, _bulletSpawn.rotation);
        
        
        if (newBullet.TryGetComponent<Rigidbody2D>(out Rigidbody2D rb))
        {
            rb.linearVelocity = _bulletSpawn.right * _bulletSpeed; 
            
        }
    }
    
}
    

