using System;
using UnityEngine;

public class Teleport1 : MonoBehaviour
{
    [SerializeField] private Transform teleports1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) other.transform.position = teleports1.position;
    }
}
