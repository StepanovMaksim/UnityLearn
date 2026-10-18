using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Н0,астройки изменения размера")]
    [Tooltip("Во сколько раз увеличится враг (например, 1.75f — это в районе 1.5 - 2 раз)")]
    [SerializeField] private float _growthMultiplier = 1.75f;

    private void Start()
    {
        StartCoroutine(LifeCycleRoutine());
    }

    private IEnumerator LifeCycleRoutine()
    {
        yield return new WaitForSeconds(2.0f);
        
        transform.localScale *= _growthMultiplier;
        
        yield return new WaitForSeconds(3.0f);
        
        Destroy(gameObject);
    }
}
