using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealPlayerScript : MonoBehaviour
{
    [SerializeField] Slider _healthSlider;
    [SerializeField] TextMeshProUGUI _healText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _healthSlider.value = _healthSlider.maxValue;
        TextHeal();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            _healthSlider.value=_healthSlider.value-1;
            TextHeal();
        } 
    }

    void TextHeal()
    {
        _healText.text = _healthSlider.value.ToString() +"/"+_healthSlider.maxValue.ToString();

    }
}