using UnityEngine;

public class GunScript2 : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _bulletSpawn;
    [SerializeField] float _fireRate = 0.5f;   
    [SerializeField] float _bulletSpeed = 15f; 
    

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)  )
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject newBullet = Instantiate(_bullet, _bulletSpawn.position, _bulletSpawn.rotation);
        
        
        if (newBullet.TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            rb.linearVelocity = _bulletSpawn.right * _bulletSpeed; 
            
        }
    }
    
}
    

