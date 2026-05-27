using UnityEngine;

public class MiniRocket : MonoBehaviour
{
    [SerializeField] GameObject _rocket;
    [SerializeField] float _lifeTime;
    [SerializeField] float _speed;
    float lifeTime;
    float PosY;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        transform.position = _rocket.transform.position + new Vector3(0, 1f, 0);
        transform.rotation = _rocket.transform.rotation;
    }

    private void FixedUpdate()
    {
        rb.AddForce(transform.up * _speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy") { 
            gameObject.SetActive(false);
            transform.position = _rocket.transform.position + new Vector3(0, 1f, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (_lifeTime > lifeTime)
        {
            lifeTime += Time.deltaTime;
        }
        else
        {
            lifeTime = 0;
            gameObject.SetActive(false);
            transform.position = _rocket.transform.position + new Vector3(0, 1f, 0);
        }
    }
}
