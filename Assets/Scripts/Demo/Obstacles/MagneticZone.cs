using UnityEngine;

public class MagneticZone : MonoBehaviour
{
    [SerializeField] float _force = 1;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Rocket")
        {
            collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(_force, 0));
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
