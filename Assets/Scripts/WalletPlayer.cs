using System.Collections;
using TMPro;
using UnityEngine;

public class WalletPlayer : MonoBehaviour
{
    [Header("Настройки UI во время игры")]
    [SerializeField] TextMeshProUGUI _coinText; // Твой текущий текст монет на экране игры
    int value = 0;

    [Header("Настройки Экрана Победы")]
    [SerializeField] private GameObject _endScreenObject; // Сюда перетащи объект 'ending'
    [SerializeField] private TextMeshProUGUI _endScreenCoinsText; // Сюда перетащи Text (TMP) для монет на экране победы
    [SerializeField] private TextMeshProUGUI _endScreenKillsText; // Сюда перетащи Text (TMP) для убийств на экране победы

    int _killedEnemiesCount = 0; // Переменная для подсчета убитых врагов

    void Start()
    {
        UpdateUI(); 
        
        // Убедимся, что при старте игры экран победы скрыт
        if (_endScreenObject != null)
        {
            _endScreenObject.SetActive(false);
        }
    }

    // Автоматическая подписка на событие таймера, когда скрипт становится активным
    private void OnEnable()
    {
        TimerScript.GameOver += TriggerWin;
    }

    // Обязательная отписка от события, чтобы избежать ошибок в памяти Unity
    private void OnDisable()
    {
        TimerScript.GameOver -= TriggerWin;
    }

    // Метод для получения денег (вызывается при сборе монеток)
    public void GetMoney(int amount)
    {
        value += amount;
        UpdateUI();
    }
    
    // МЕТОД ДЛЯ ВРАГОВ: Вызывается из скрипта врага при его смерти
    public void RegisterKill()
    {
        _killedEnemiesCount++;
    }

    // МЕТОД ДЛЯ ПОБЕДЫ: Вызывается автоматически по сигналу таймера GameOver
    public void TriggerWin()
    {
        if (_endScreenObject != null)
        {
            // Включаем экран победы
            _endScreenObject.SetActive(true);

            // Записываем финальные значения в поля экрана победы
            if (_endScreenCoinsText != null) 
                _endScreenCoinsText.text = value.ToString();

            if (_endScreenKillsText != null) 
                _endScreenKillsText.text = _killedEnemiesCount.ToString();

            // Останавливаем время в игре, чтобы всё замерло после победы
            Time.timeScale = 0f; 
        }
    }

    void UpdateUI()
    {
        if (_coinText != null)
        {
            _coinText.text = "Money: " + value;
        }
    }

    void Update()
    {
        // Проверочный код на кнопку P для добавления денег
        if (Input.GetKeyDown(KeyCode.P))
            GetMoney(10);

        // Временная проверка: если нажать кнопку K, включится экран победы раньше времени
        if (Input.GetKeyDown(KeyCode.K))
            TriggerWin();
    }

    private void OnDestroy()
    {
        // Возвращаем время в норму при перезапуске сцены или смене уровня
        Time.timeScale = 1f;
    }
}