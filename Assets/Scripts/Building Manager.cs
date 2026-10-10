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
        for (int i = 0; i < _buildings.Length; i++)
        {
            if (i == _number1[0]) _buildings[i].SetActive(true);
            else _buildings[i].SetActive(false);
        } 
            

    }
    
    
    // Update is called once per frame
    void Update()
    {

    }
}
