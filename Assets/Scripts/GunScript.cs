using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _fireEffect;
    [SerializeField] private Transform _bulletSpawn;

    [SerializeField] private float _fireRate = 0.1f;
    [SerializeField] private Animator _animator;

    private float _nextFire;

    void Start()
    {
        _nextFire = _fireRate;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (_animator != null)
            {
                _animator.SetBool("IsShooting", true);
            }

            if (_fireRate > 0)
            {
                _fireRate -= Time.deltaTime;
            }
            else
            {
                Instantiate(_bullet, _bulletSpawn.position, _bulletSpawn.rotation);
                Instantiate(_fireEffect, _bulletSpawn.position, _bulletSpawn.rotation);
                _fireRate = _nextFire;
            }
        }
        else
        {
            if (_animator != null)
            {
                _animator.SetBool("IsShooting", false);
            }
        }
    }
}