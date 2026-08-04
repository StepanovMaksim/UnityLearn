using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public float fireRate = 0.2f;   
    private float nextFireTime = 0f;

    void Update()
    {
        
        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate; 
        }
    }

    void Shoot()
    {
        
        GameObject newBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        
        
        Rigidbody rb = newBullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(transform.forward * 100000000, ForceMode.Impulse);
        }
    }
}
