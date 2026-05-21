using UnityEngine;

public class SplashAnim : MonoBehaviour
{
    public void OnFinishAnimation() // Desativa o splash quando acaba a animação
    {
        gameObject.SetActive(false);
    }
}
