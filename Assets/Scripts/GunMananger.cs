using UnityEngine;

public class GunMananger : MonoBehaviour
{
    [SerializeField] private GameObject[] _guns;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _aimTransform;
    [SerializeField] private float _cameraDistance = 40f; 
    [SerializeField] private float _smoothSpeed = 10f;    

    private int _gunIndex;
    private Vector3[] _defaultPositions;
    private bool _isAiming = false; 
    private float _defaultFOV = 60f;

    private void Start()
    {
        _defaultPositions = new Vector3[_guns.Length];
        for (int i = 0; i < _guns.Length; i++)
        {
            _defaultPositions[i] = _guns[i].transform.localPosition;
        }

        ActiveGun(0);
    }

    void Update()
    {
        // Смена оружия на клавиши 1, 2, 3
        if (Input.GetKeyDown(KeyCode.Alpha1)) ActiveGun(0);
        else if (Input.GetKeyDown(KeyCode.Alpha2)) ActiveGun(1);
        else if (Input.GetKeyDown(KeyCode.Alpha3)) ActiveGun(2);

        // Проверяем нажатие и отпускание правой кнопки мыши
        if (Input.GetMouseButtonDown(1))
        {
            _isAiming = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            _isAiming = false;
        }

        // Плавное управление прицеливанием
        AnimateAiming();
    }

    private void AnimateAiming()
    {
        float targetFOV = _isAiming ? _cameraDistance : _defaultFOV;
        
        Vector3 targetWeaponPos = _isAiming 
            ? _guns[_gunIndex].transform.parent.InverseTransformPoint(_aimTransform.position) 
            : _defaultPositions[_gunIndex];
        
        _camera.fieldOfView = Mathf.Lerp(_camera.fieldOfView, targetFOV, Time.deltaTime * _smoothSpeed);
        
        _guns[_gunIndex].transform.localPosition = Vector3.Lerp(
            _guns[_gunIndex].transform.localPosition, 
            targetWeaponPos, 
            Time.deltaTime * _smoothSpeed
        );
    }

    void ActiveGun(int index)
    {
        if (_guns != null && _guns[_gunIndex].activeSelf)
        {
            _guns[_gunIndex].transform.localPosition = _defaultPositions[_gunIndex];
        }

        _gunIndex = index;
        for (int i = 0; i < _guns.Length; i++)
        {
            _guns[i].SetActive(i == _gunIndex);
        }
        
        _isAiming = false; 
    }
}
