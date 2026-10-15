using System.Linq;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _buildings;
    [SerializeField] private int[] _number1;

    [Header("Настройки размера")]
    // Задайте здесь размер для активированных зданий (например, X: 1.5, Y: 1.5, Z: 1.5)
    [SerializeField] private Vector3 _activeScale = new Vector3(1.5f, 1.5f, 1.5f);
    // Обычный размер для выключенных или фоновых зданий
    [SerializeField] private Vector3 _defaultScale = Vector3.one; 

    void Start()
    {
        RenderBuildings();
    }

    void RenderBuildings()
    {
        for (int i = 0; i < _buildings.Length; i++)
        {
            // Проверяем, должно ли здание быть активным
            bool shouldBeActive = _number1.Contains(i);
            
            // Включаем или выключаем объект
            _buildings[i].SetActive(shouldBeActive);

            // Если здание включено — увеличиваем его, иначе — возвращаем стандартный размер
            if (shouldBeActive)
            {
                _buildings[i].transform.localScale = _activeScale;
            }
            else
            {
                _buildings[i].transform.localScale = _defaultScale;
            }
        }
    }
}
