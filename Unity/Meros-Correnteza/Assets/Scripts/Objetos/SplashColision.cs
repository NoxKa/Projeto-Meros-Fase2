using UnityEngine;

public class SplashColision : MonoBehaviour
{
   private GameObject splashUI; // Imagem de splash no canvas
   private SplashAnim splashAnim; // Script de animação do splash
    void Start()
    {
        splashUI = FindFirstObjectByType<UI_Manager>().splashUI;
        splashAnim = splashUI.GetComponent<SplashAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        splashUI.SetActive(false); // Ativa o splash
        splashUI.SetActive(true); // Ativa o splash
        Destroy(gameObject);
    }
}
