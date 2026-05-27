using UnityEngine;

public class FireRocket : MonoBehaviour
{
    [SerializeField] ParticleSystem _smoke;
    ParticleSystem _ps;
    // Start is called before the first frame update
    void Start()
    {
        _ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            var mainModule = _ps.main;

            mainModule.startSize = 0.75f;
            var mainModuleSmoke = _smoke.main;
            mainModuleSmoke.startSize = new ParticleSystem.MinMaxCurve(mainModuleSmoke.startSize.constantMin * 2f, mainModuleSmoke.startSize.constantMin * 4f);
        }
        if (Input.GetMouseButtonUp(0))
        {

            var mainModule = _ps.main;
            mainModule.startSize = 0.5f;
            var mainModuleSmoke = _smoke.main;
            mainModuleSmoke.startSize = new ParticleSystem.MinMaxCurve(mainModuleSmoke.startSize.constantMin / 2f, mainModuleSmoke.startSize.constantMin / 4f);
        }
    }
}
