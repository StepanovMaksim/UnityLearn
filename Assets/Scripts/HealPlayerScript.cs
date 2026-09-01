using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealPlayerScript : MonoBehaviour
{
    [SerializeField] Slider _healthSlider;
    [SerializeField] TextMeshProUGUI _healthTxt;

    void Start()
    {
        _healthSlider.value = _healthSlider.maxValue;
        TextHeal();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            _healthSlider.value = _healthSlider.value - 1;
            TextHeal();
        }
    }

    void TextHeal()
    {
        _healthTxt.text = _healthSlider.value.ToString() + "/" + _healthSlider.maxValue.ToString();
    }

    // НОВЫЙ МЕТОД: Получение урона от врага
    public void TakeDamage(int damage)
    {
        // Отнимаем здоровье у слайдера UI
        _healthSlider.value -= damage;
        
        // Обновляем текст на экране
        TextHeal();

        Debug.Log("Игрок получил урон! Текущее здоровье: " + _healthSlider.value);

        if (_healthSlider.value <= 0)
        {
            Debug.Log("Игрок погиб!");
            // Сюда можно добавить логику смерти
        }
    }
}