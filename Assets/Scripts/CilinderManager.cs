using UnityEngine;

public class CilinderManager : MonoBehaviour
{
    [SerializeField] GameObject[] _cilinders;
    [SerializeField] int _numberOn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // нужно создать переменную
        int i = 0;
        // условие продолжения цикла
        while (i < _cilinders.Length) 
        {
            if (i < _numberOn)                      // если меньше нашего номера, то включаем
                _cilinders[i].SetActive(true);
            else                                    // если больше, то выключаем
                _cilinders[i].SetActive(false);
            i++;         // делаем в конце цикла, чтобы цикл завершался
        }
    }


    void ForCicle()
    {
        //  начало цикла; условия продолжения цикла; что делать в конце каждого цикла, чтобы цикл завершался
        for (int i = 0; i < _cilinders.Length; i++)
        {
            if (i < _numberOn)                      // если меньше нашего номера, то включаем
                _cilinders[i].SetActive(true);
            else                                    // если больше, то выключаем
                _cilinders[i].SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
