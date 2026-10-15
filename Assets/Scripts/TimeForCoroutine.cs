using System.Collections;
using UnityEngine;

public class TimeForCoroutine : MonoBehaviour
{
    [SerializeField] GameObject _build;
    [SerializeField] float _time = 2f;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(BuildOn());
    }


    IEnumerator BuildOn()
    {
        while (true)
        {
            yield return new WaitForSeconds(_time);
            _build.SetActive(true);
            yield return new WaitForSeconds(_time);
            _build.SetActive(false);
        }
    }

   /* void Update ()
    {
        if ( _time < 0)
        {
            _build.SetActive(true);
            _time -= Time.deltaTime;
            if (_time < -2)
            {
                _build.SetActive(false);
            }
        }
        else
        {
            _time -= Time.deltaTime;
        }
    }*/
  
}
