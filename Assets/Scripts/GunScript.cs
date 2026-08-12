using UnityEngine;

public class GunScript : MonoBehaviour
{
    
    [SerializeField] GameObject _bullet;
    [SerializeField] GameObject _fireEffect;
    [SerializeField] Transform _bulletSpawn;

    [SerializeField] private float _fireRate = 0.1f;
    private float _nextFire;

    void Start()
    {
        _nextFire = _fireRate;
    }

    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            
            if (_fireRate > 0)
                _fireRate -= Time.deltaTime;
            else
            {
                 Instantiate(_bullet, _bulletSpawn.position, _bulletSpawn.rotation);
                 Instantiate(_fireEffect, _bulletSpawn.position, _bulletSpawn.rotation);
                 _fireRate = _nextFire;
            }
           
           
        }
    }
}
