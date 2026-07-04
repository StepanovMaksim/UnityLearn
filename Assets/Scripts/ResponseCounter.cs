using TMPro;
using UnityEngine;

// ������� ������� ������
public class ResponseCounter : MonoBehaviour
{
    [SerializeField] private GameObject[] _starImages; 
    [SerializeField] private GameObject[] _heartImages;
    [SerializeField] TextMeshProUGUI textCountFalse;
    [SerializeField] TextMeshProUGUI _textCount;
    int _count = 0;
    int _countFalse = 0;
    public int TrueChoice()
    {
        return _count;
    }

    public int FalseChoice()
    {
        return _countFalse;
    }
    public void CountFalse()
    {
        ActiveHearts();
        _countFalse = _countFalse + 1;
        textCountFalse.text = _countFalse.ToString();
        
    }
    public void PlusCount()
    {
        ActiveStars();
        _count = _count + 1;
        _textCount.text = _count.ToString();
    }

    void ActiveStars()
    {
        _starImages[_count].SetActive(true);
        
    }

    void ActiveHearts()
    {
        _heartImages[_countFalse].SetActive(true);
    }     
       
}


   