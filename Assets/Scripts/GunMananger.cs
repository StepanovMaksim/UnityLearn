using UnityEngine;

public class GunMananger : MonoBehaviour
{
    [SerializeField] private GameObject _Gun1;
    [SerializeField] private GameObject _Gun2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _Gun2.SetActive(true);
            _Gun1.SetActive(false); 
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _Gun2.SetActive(false);
            _Gun1.SetActive(true);
        }   
            
    }
}
