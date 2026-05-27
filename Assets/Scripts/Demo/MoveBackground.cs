using System.Net.Sockets;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] float _speedX;
    [SerializeField] float _speedY;
    Rigidbody2D rbRocket;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbRocket = GameObject.Find("Rocket").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rbRocket.linearVelocity.y * Time.deltaTime * _speedY / 2, rbRocket.linearVelocity.x * Time.deltaTime * _speedX, 0);
    }
}
