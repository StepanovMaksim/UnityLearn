using TMPro;
using UnityEngine;
// ������� ������� �� ������
public class FinishCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _trueChoice;  // "����� �������: "
    [SerializeField] TextMeshProUGUI _falseChoice;  // "������� �������: "

    ResponseCounter _responseCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _responseCounter = transform.parent.GetComponent<ResponseCounter>();
        _trueChoice.text =   _responseCounter.TrueChoice().ToString();
        _falseChoice.text =   _responseCounter.FalseChoice().ToString();
    }


}
