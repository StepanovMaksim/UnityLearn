using TMPro;
using UnityEngine;

public class ResponseCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textCount;
    int _count = 0;

    public void PlusCount()
    {
        _count = _count + 1;
        _textCount.text = _count.ToString();
    } 
}
