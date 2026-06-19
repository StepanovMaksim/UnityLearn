using UnityEngine;
// Скрипт для управления окнами
public class ManangerQuestions : MonoBehaviour
{
    [SerializeField] GameObject _no;
    [SerializeField] GameObject _yes;
    [SerializeField] GameObject[] _questions;
    int _number = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _questions[_number].SetActive(true);
    }

    public void NextQuestion()
    {
        _questions[_number].SetActive(false);
        _number = _number + 1; // _number = 0 + 1
        _questions[_number].SetActive(true);
    }

    public void FalseChoice()
    {
        _yes.SetActive(false);
        _no.SetActive(true);
    }


    public void RightChoice()
    {
        _yes.SetActive(true);
        _no.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
