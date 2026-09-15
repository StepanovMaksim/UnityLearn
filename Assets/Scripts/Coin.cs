using System;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinValue = 5; 
    [SerializeField] private float _speedRotate;
    private float startPosY;
    bool _goUp = true;
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
        transform.Rotate( Vector3.forward, Time.deltaTime * _speedRotate); // вращаем монету
        if (_goUp == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1f * Time.deltaTime, transform.position.z);
            if (transform.position.y > startPosY + 0.3f)  // проверяем, что высота меньше максимальной
            {
                _goUp = false;
            }
        }
        else // _goUp == false
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1f * Time.deltaTime, transform.position.z);
            if (transform.position.y < startPosY - 0.3f)
            {
                _goUp = true;
            }
        }
             
    }
}
