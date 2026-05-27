using UnityEngine;

public class TopMove : MonoBehaviour
{
    Transform rocket;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rocket = GameObject.Find("Rocket").GetComponent<Transform>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector2(0, rocket.position.y);
    }
}
