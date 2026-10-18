using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] int _time;
    public static Action GameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(TimerCoroutine());
    }

    IEnumerator TimerCoroutine()
    {
        timerText.text = _time.ToString();
        while (_time > 0)
        {
          yield return new WaitForSeconds(1f);
                  _time--;
                  timerText.text = _time.ToString();
        }
        Debug.Log("время закончилось");
        GameOver?.Invoke();
    }
        
}
   