using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _bulletSpawn;

    [SerializeField] private float _fireRate = 0.1f; 
     

    void Start()
    {
        
    }

    void Update()
    {
        
        if (Input.GetMouseButton(0) && 0 >= _fireRate)
        {
            if 
            Instantiate(_bullet, _bulletSpawn.position, _bulletSpawn.rotation);
           
        }
    }
}
