using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    [SerializeField] GameObject _endGame;
    [SerializeField] GameObject _crashEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            gameObject.SetActive(false);
            _endGame.SetActive(true);
            Instantiate(_crashEffect, transform.position, Quaternion.identity); 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
