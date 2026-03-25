using UnityEngine;

public class EntulhoColider : MonoBehaviour
{
    public int dano;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        var playerVidas = other.gameObject.GetComponent<PlayerVidas>();
        playerVidas.MudarVida(dano);
    }
}
