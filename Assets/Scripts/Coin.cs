using System;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinValue = 5; 
    [SerializeField] private float _speedRotate;
    private float startPosY;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WalletPlayer playerWallet = other.GetComponent<WalletPlayer>();

            if (playerWallet != null)
            {
                playerWallet.GetMoney(_coinValue);
                Destroy(gameObject);
            }
        }
    }

    void Start()
    {
        startPosY = transform.position.y;
    }

    private void Update()
    {
        transform.Rotate( Vector3.forward, Time.deltaTime * _speedRotate);
        if (transform.position.y < startPosY+0.5f)
        {
            transform.position = new Vector3( transform.position.x , transform.position.y + 1f*Time.deltaTime, transform.position.z);
        }
        transform.position = new Vector3(transform.position.x , transform.position.y - 1f*Time.deltaTime , transform.position.z); 
    }
}
