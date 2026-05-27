using UnityEngine;

public class Wave : MonoBehaviour
{
    [SerializeField] float _finishSize;
    [SerializeField] float _speed;
    float size;
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (size / _finishSize < 1f)
        {
            size = size + _speed * Time.deltaTime;
            gameObject.transform.localScale = new Vector2(size, size);
        }
        else
        {
            size = 0;
            gameObject.SetActive(false);
        }
        


    }
}
