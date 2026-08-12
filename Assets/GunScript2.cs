using UnityEngine;

public class GunScript2 : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _bulletSpawn;
    [SerializeField] float _fireRate = 0.5f;

    // —сылка на Animator (перетащи сюда компонент Animator в инспекторе)
    [SerializeField] private Animator _animator;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // ≈сли Animator назначен Ч запускаем триггер дл€ анимации выстрела
        if (_animator != null)
        {
            _animator.SetTrigger("Shoot");
        }

        GameObject newBullet = Instantiate(_bullet, _bulletSpawn.position, _bulletSpawn.rotation);

    }
}
