using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Transform _rocket;
    // Start is called before the first frame update
    void Start()
    {
        _rocket = GameObject.Find("Rocket").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = _rocket.position;
    }
}
