using UnityEngine;

public class ManangerQuestions : MonoBehaviour
{       [SerializeField] GameObject _no;
        [SerializeField] GameObject _yes;
        [SerializeField] GameObject[] _questions;
    
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        _questions[0].SetActive(true);
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
