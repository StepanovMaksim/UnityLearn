using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Rigidbody _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(transform.forward * 100000000, ForceMode.Impulse); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
