using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField] float _force = 1;
    float radius;
    float forceX;
    float forceY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Rocket")
        {
            if (gameObject.transform.position.x - collision.transform.position.x > 0)
                forceX = gameObject.transform.position.x - collision.transform.position.x + radius;
            else
                forceX = gameObject.transform.position.x - collision.transform.position.x - radius;
            if (gameObject.transform.position.y - collision.transform.position.y > 0)
                forceY = gameObject.transform.position.y - collision.transform.position.y + radius;
            else
                forceY = gameObject.transform.position.y - collision.transform.position.y - radius;
            collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(forceX * _force, forceY * _force));
        }
    }
    void Start()
    {
        radius = gameObject.GetComponent<CircleCollider2D>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
