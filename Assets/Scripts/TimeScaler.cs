using UnityEngine;

public class TimeScaler : MonoBehaviour
{
    [SerializeField] float _fastSpeed = 1f;
    [SerializeField] float _lowSpeed = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
            Time.timeScale = _lowSpeed;
        else
            Time.timeScale = _fastSpeed;
    }
}
