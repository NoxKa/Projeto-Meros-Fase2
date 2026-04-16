using UnityEngine;

public class SplashColision : MonoBehaviour
{
   private GameObject splashUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
        splashUI.SetActive(true);
        Destroy(this.gameObject);
    }
}
