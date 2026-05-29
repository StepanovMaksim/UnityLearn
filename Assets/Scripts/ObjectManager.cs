using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            OffObject();
    }

    public void OffObject()
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    public void OnObject()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
