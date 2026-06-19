using System;
using UnityEngine;

public class QuestionScript : MonoBehaviour
{
    
    [SerializeField] GameObject _choiceButtons;
    [SerializeField] GameObject _nextButtons;
    
    ManangerQuestions _manangerQuestions;
    ResponseCounter _responseCounter;


    private void Start()
    {
        
        _responseCounter = transform.parent.GetComponent<ResponseCounter>();
        _manangerQuestions = transform.parent.GetComponent<ManangerQuestions>();
    }

    public void FalseChoice()
    {
        _choiceButtons.SetActive(false);
        
        _manangerQuestions.FalseChoice();
        _nextButtons.SetActive(true);
    }


    public void RightChoice()
    {
        _choiceButtons.SetActive(false);
        _manangerQuestions.RightChoice();
        _responseCounter.PlusCount();
        _nextButtons.SetActive(true);
        
    }


    public void NextQuestion()
    {
        _manangerQuestions.NextQuestion();
    }

}
        
    


