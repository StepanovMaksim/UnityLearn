using UnityEngine;

public class GunMananger : MonoBehaviour
{
    [SerializeField] private GameObject[] _guns;
    [SerializeField]  Camera _camera;
    [SerializeField]  Transform _aimTransform;
    [SerializeField] float _cameraDistance;
    int _gunIndex; // номер активного оружия

    private void Start()
    {
        ActiveGun(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActiveGun(0);
        }


        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActiveGun(1);
        }



        if (Input.GetMouseButtonDown(1))
        {
            _camera.fieldOfView = _cameraDistance;
            _guns[_gunIndex].transform.position = _aimTransform.position;
        }

        if (Input.GetMouseButtonUp(1))
        {
             _camera.fieldOfView = 60f;
        }
    }

    void ActiveGun(int index)
    {
        _gunIndex = index;
        for (int i = 0; i < _guns.Length; i++)
        {
            if (_gunIndex == i)
            {
                _guns[i].SetActive(true);
            }
            else
            {
                _guns[i].SetActive(false);
            }
        }
    }
}
