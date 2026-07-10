using UnityEngine;

public class HeroAnimator : MonoBehaviour
{
    [SerializeField] Animator _heroAnimator;

    public void RigthChoise()
    {
        _heroAnimator.SetTrigger("RightChoise");
    }
}
