using UnityEngine;

public class SplashColision : MonoBehaviour
{
   private GameObject splashUI; // Imagem de splash no canvas
   private SplashAnim splashAnim;
   private EntulhoSprite entulhoSprite;
    private void OnTriggerEnter2D(Collider2D other)
    {
        entulhoSprite = GetComponentInChildren<EntulhoSprite>();
        splashAnim = splashUI.GetComponent<SplashAnim>();
        splashUI.SetActive(false); // Ativa o splash
        Debug.Log("Change colors "+entulhoSprite.CorSprite());
        splashAnim.CorTinta(entulhoSprite.CorSprite());
        splashUI.SetActive(true); // Ativa o splash
        Destroy(gameObject);
    }
    public void Init(GameObject splash)
    {
        splashUI = splash;
    }
}
