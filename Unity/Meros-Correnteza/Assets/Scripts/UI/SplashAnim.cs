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
    public void OnFinishAnimation() // Desativa o splash quando acaba a animação
    {
        gameObject.SetActive(false);
    }
}
