using UnityEngine;
using UnityEngine.AI;

public class SplashAnim : MonoBehaviour
{
    private Animator splashAnimator;
    void Start()
    {
        splashAnimator = GetComponent<Animator>();   
    }   

    void Update()
    {
        
    }
    void OnEnable()
    {
        splashAnimator.Play("Splash", 0, 0f);
    }
    public void OnFinishAnimation() // Desativa o splash quando acaba a animação
    {
        gameObject.SetActive(false);
    }
    public void StartAnimation()
    {
        splashAnimator.Play("Splash", 0, 0f);
    }
}
