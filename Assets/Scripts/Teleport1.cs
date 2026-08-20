using UnityEngine;

public class Teleport1 : MonoBehaviour
{
    [SerializeField] private Transform targetPoint;
    [SerializeField] private Vector3 spawnOffset = new Vector3(2f, 0f, 0f);

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && targetPoint != null)
        {
            other.transform.position = targetPoint.position + spawnOffset;
        }
    }
}
