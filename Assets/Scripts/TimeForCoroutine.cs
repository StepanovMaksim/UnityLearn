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
        yield return new WaitForSeconds(_time);
        _build.SetActive(true);
        yield return new WaitForSeconds(_time + 2f);
        _build.SetActive(false);
    }
}
