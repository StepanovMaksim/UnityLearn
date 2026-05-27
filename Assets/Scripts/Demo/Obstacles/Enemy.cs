using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float eulerRotate;
    private void Start()
    {
        eulerRotate = Random.Range(0, 360f);
        transform.rotation = Quaternion.Euler(0,0, eulerRotate);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Gun")
            Destroy(gameObject);
    }
}
