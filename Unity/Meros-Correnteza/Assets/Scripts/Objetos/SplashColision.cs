using UnityEngine;

public class SplashColision : MonoBehaviour
{
   private GameObject splashUI; // Imagem de splash no canvas
    void Start()
    {
        splashUI = FindFirstObjectByType<UI_Manager>().splashUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        splashUI.SetActive(true); // Ativa o splash
        Destroy(this.gameObject);
    }
}
