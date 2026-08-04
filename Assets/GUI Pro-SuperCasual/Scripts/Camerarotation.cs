using UnityEngine;

public class Camerarotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 4f;
    float xRotation = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        xRotation -= mouseY; 
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.Rotate(Vector3.up * mouseX);
        transform.Rotate(Vector3.right * mouseY);
        //Camera.main.transform.localEulerAngles = new Vector3(xRotation, 0f, 0f);
    }
}
