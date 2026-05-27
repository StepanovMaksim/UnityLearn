using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Record : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _recordText;
    Transform _rocket;
    // Start is called before the first frame update
    void Start()
    {
        _rocket = GameObject.Find("Rocket").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _recordText.text = "—чет: " + (int)_rocket.transform.position.y;
    }
}
