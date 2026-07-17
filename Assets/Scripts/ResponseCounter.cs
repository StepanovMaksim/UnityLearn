using TMPro;
using UnityEngine;

// ������� ������� ������
public class ResponseCounter : MonoBehaviour

{
    [SerializeField] private GameObject[] _finishHeartImages;
    [SerializeField] private GameObject[] _finishStarsImages;
    [SerializeField] private GameObject[] _starImages;
    [SerializeField] private GameObject[] _heartImages;
    [SerializeField] TextMeshProUGUI textCountFalse;
    [SerializeField] TextMeshProUGUI _textCount;
    [Header("Эффекты")]
    [SerializeField] GameObject _effectTrue;
    [SerializeField] GameObject _effectFalse;
    [Header("Герой")] 
    [SerializeField] HeroAnimator _heroAnimator;
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
        _effectFalse.SetActive(true);
        _heroAnimator.FalseChoise();
    }
    public void PlusCount()
    {
        ActiveStars();
        _count = _count + 1;
        _textCount.text = _count.ToString();
        _effectTrue.SetActive(true);
        _heroAnimator.RigthChoise();
    }

    void ActiveStars()
    {
        _finishStarsImages[_count].SetActive(true);
        _starImages[_count].SetActive(true);

    }

    void ActiveHearts()
    {
        if (_countFalse < _finishHeartImages.Length)
        {
            _finishHeartImages[_countFalse].SetActive(false);
            _heartImages[_countFalse].SetActive(false);
        }
    }

}


