using UnityEngine;

public class GunScript2 : MonoBehaviour
{
    
    public float spreadAngle = 5f;
    public int pelletsCount = 8;
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _bulletSpawn;
    [SerializeField] float _fireRate = 0.5f;
    [SerializeField] GameObject _fireEffect;
    // ������ �� Animator (�������� ���� ��������� Animator � ����������)
    [SerializeField] private Animator _animator;
    private float _nextFireTime = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= _nextFireTime)
        {
            Shoot();
            _animator.SetTrigger("Shoot");
            
            _nextFireTime = Time.time + 2f; 
        }
    }

    void Shoot()
    {
        
        for (int i = 0; i < pelletsCount; i++)
        {
            // Рассчитываем случайный угол разброса
            float randomX = Random.Range(-spreadAngle, spreadAngle);
            float randomY = Random.Range(-spreadAngle, spreadAngle);
            Quaternion spreadRotation = Quaternion.Euler(randomX, 0, randomY);

            // Итоговое направление пули с учетом разброса
            Quaternion finalRotation = _bulletSpawn.rotation * spreadRotation;

            // Спавним каждую пулю как отдельный GameObject
            GameObject pellet = Instantiate(_bullet, _bulletSpawn.position, finalRotation);
            Instantiate(_fireEffect, _bulletSpawn.position, _bulletSpawn.rotation);
        }
    }
}
