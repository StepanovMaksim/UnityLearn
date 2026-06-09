using TMPro;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] int _number; //числа, такие как 0,1,2,3
    [SerializeField] float _time; //числа, такие как 0,1,2,3
    [SerializeField] string[] _string; //символы, буквы и т.д. например "слово"
    [SerializeField] GameObject[] _windows;
    [SerializeField] TextMeshProUGUI[] _windowsText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    string _consoleString;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        if (_time > _number+1)
        {
            if (_windows[_number] != null)
                _windows[_number].SetActive(true);
            if (_windowsText[_number] != null)
                _windowsText[_number].text = _string[_number];
            _number++;
        }

    }
}
