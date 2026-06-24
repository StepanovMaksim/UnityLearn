using TMPro;
using UnityEngine;
// Счетчик ответов на финише
public class FinishCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _trueChoice;  // "Верно ответов: "
    [SerializeField] TextMeshProUGUI _falseChoice;  // "Неверно ответов: "

    ResponseCounter _responseCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _responseCounter = transform.parent.GetComponent<ResponseCounter>();
        _trueChoice.text = _trueChoice.text + _responseCounter.TrueChoice();
    }


}
