using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float BackgoundSpeed;
    Renderer BackgroundRenderer;
    Rigidbody2D _rbRocket;
    void Start()
    {
        BackgroundRenderer = GetComponent<Renderer>();
        _rbRocket = GameObject.Find("Rocket").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
            BackgroundRenderer.material.mainTextureOffset += new Vector2(_rbRocket.linearVelocity.x*Time.deltaTime* BackgoundSpeed/2, _rbRocket.linearVelocity.y * Time.deltaTime * BackgoundSpeed);
        
        
    }
}
