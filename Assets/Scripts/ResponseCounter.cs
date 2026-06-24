using TMPro;
using UnityEngine;

// —четчик ответов игрока
public class ResponseCounter : MonoBehaviour
{
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
        _countFalse = _countFalse + 1;
        textCountFalse.text = _countFalse.ToString();
    }
    public void PlusCount()
    {
        
        _count = _count + 1;
        _textCount.text = _count.ToString();
    } 


}

   