using UnityEngine;

public class BuildingMananger : MonoBehaviour
{
    [SerializeField] GameObject[] _buildings;
    [SerializeField] int _numberOn;
    [SerializeField] private int[] _number1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NumderBuildings();
    }


    void ForCicle()
    {

        for (int i = 0; i < _buildings.Length; i++)
        {
            if (i < _numberOn)
                _buildings[i].SetActive(true);
            else
                _buildings[i].SetActive(false);
        }
    }

    void NumderBuildings()
    {
        // nubmber1 = [4,2,3,8]
        for (int i = 0; i < _buildings.Length; i++)
        {
            for (int j = 0; j < _number1.Length; j++)
            {
                if (i == _number1[j])
                {
                    _buildings[i].SetActive(true);
                    break;
                }    
                else 
                    _buildings[i].SetActive(false);
            }
        }


    }


    // Update is called once per frame
    void Update()
    {

    }
}
