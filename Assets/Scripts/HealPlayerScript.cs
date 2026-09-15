using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; // Нужно для перезапуска сцены при смерти игрока

public class HealPlayerScript : MonoBehaviour
{
    [SerializeField] Slider _healthSlider;
    [SerializeField] TextMeshProUGUI _healthTxt;
    [SerializeField] Image _imageTrigger;
    [SerializeField] GameObject _deathEffectPrefab;
    [SerializeField] GameObject _coinPrefab; 

    float _damageNow;

    void Start()
    {
        _healthSlider.value = _healthSlider.maxValue;
        TextHeal();
    }

    void Update()
    {
      //  if (Input.GetKeyDown(KeyCode.P))
        {
          //  _healthSlider.value = _healthSlider.value - 1;
           // TextHeal();
        }

        if (_damageNow > 0)
        {
            _imageTrigger.color = new Color(_imageTrigger.color.r, _imageTrigger.color.g, _imageTrigger.color.b, _damageNow);
            _damageNow -= Time.deltaTime / 2f;
        }
    }

    void TextHeal()
    {
        _healthTxt.text = _healthSlider.value.ToString() + " / " + _healthSlider.maxValue.ToString();
    }

    // Метод получения урона
    public void TakeDamage(int damage)
    {
        // Отнимаем здоровье у слайдера UI
        _healthSlider.value -= damage;

        // Обновляем текст на экране
        TextHeal();

        Debug.Log(gameObject.name + " получил урон! Текущее здоровье: " + _healthSlider.value);
        _damageNow = 1f;
        
        // ПРОВЕРКА НА СМЕРТЬ:
        if (_healthSlider.value <= 0)
        {
            if (gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Враг погиб!");

                // Спавним эффект на позиции врага и с его поворотом
                if (_deathEffectPrefab != null)
                {
                    Instantiate(_deathEffectPrefab, transform.position, transform.rotation);
                }
                
                if (_coinPrefab != null)
                {
                    Instantiate(_coinPrefab, transform.position, transform.rotation);
                }

                Destroy(gameObject); // Удаляем самого врага
            }
            else 
            {
                Debug.Log("Игрок погиб! Перезапуск уровня...");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}