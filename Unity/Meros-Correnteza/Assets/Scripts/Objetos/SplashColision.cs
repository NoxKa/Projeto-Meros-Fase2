using UnityEngine;

public class SplashColision : MonoBehaviour
{
   private GameObject splashUI; // Imagem de splash no canvas
    private void OnTriggerEnter2D(Collider2D other)
    {
        splashUI.SetActive(false); // Ativa o splash
        splashUI.SetActive(true); // Ativa o splash
        Destroy(gameObject);
    }
    public void Init(GameObject splash)
    {
        splashUI = splash;
    }
}
