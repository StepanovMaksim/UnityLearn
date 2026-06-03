using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            OnObject();
    }

    public void OffObject()
    {
        gameObject.SetActive(false);
    }

    public void OnObject()
    {
        gameObject.SetActive(true);
    }
}
