using UnityEngine;

public class ControllerMy : MonoBehaviour
{
    [SerializeField] float _maxSpeed;
    [SerializeField] float _speedRight;
    [SerializeField] float _speedRotate;
    [SerializeField] float _speedDelta;
    Transform camera;
    Rigidbody2D rb;
    float speed;
    float speedRight;
    float oldMousePositionX;
    float eulerY;
    bool ruleRoket;
    float forceY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        camera = GameObject.Find("Camera").GetComponent<Transform>();
    }

    private void Update()
    {
        
        if (Input.GetMouseButtonUp(0))
        {
            speed = _maxSpeed / 10f;
            ruleRoket = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            oldMousePositionX = Input.mousePosition.x;
            ruleRoket = true;
            if (rb.linearVelocityX < 0.2f || rb.linearVelocityX > -0.2f)
                rb.linearVelocityX = 0;
            forceY = rb.linearVelocityX;
            if (transform.eulerAngles.z < 360f && transform.eulerAngles.z > 180f)
                eulerY = transform.eulerAngles.z - 360f;
        }

        if (Input.GetMouseButton(0))
        {
            /* float deltaX = Input.mousePosition.x - _oldMousePositionX;
             _oldMousePositionX = Input.mousePosition.x;
             _eulerY += deltaX * 0.15f;
             _eulerY = Mathf.Clamp(_eulerY, -38, 38);
             transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, _eulerY); */
            if (speed < _maxSpeed)
            {
                speed += _speedDelta * Time.deltaTime;
            }
            float deltaX = Input.mousePosition.x - oldMousePositionX;

            eulerY -= deltaX * 0.005f;
            forceY += deltaX * 0.03f;
            speedRight = _speedRight * forceY;
            eulerY = Mathf.Clamp(eulerY, -15, 15);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, eulerY, eulerY );
        }

        if (!ruleRoket)
        {
            eulerY = transform.eulerAngles.z;
            if (transform.eulerAngles.z < 359f && transform.eulerAngles.z > 180f)
            {
                eulerY += _speedRotate * Time.deltaTime;
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, eulerY, eulerY);
            }
            else if (transform.eulerAngles.z > 1f && transform.eulerAngles.z <= 180f)
            {
                eulerY -= _speedRotate * Time.deltaTime;
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, eulerY, eulerY);
            }

        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetMouseButton(0))
        {
            rb.AddForce(transform.up * speed);
            rb.AddForce(transform.right * speedRight);
        }

    }
}
