using TMPro;
using UnityEngine;

public class WalletPlayer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _coinText;
    int value = 0;

    void Start()
    {
        // Сразу обновляем текст при старте игры, чтобы было "Money: 0"
        UpdateUI(); 
    }

    // Сделали метод PUBLIC и добавили аргумент (int amount), чтобы передавать +5 денег
    public void GetMoney(int amount)
    {
        value += amount;
        UpdateUI();
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
        if (Input.GetKeyDown(KeyCode.P))
            GetMoney(10);
    }
}
