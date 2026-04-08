using Unity.VisualScripting;
using UnityEngine;

public class EntulhoColider : MonoBehaviour
{
    public int dano;
    public bool isPonto;
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
        print("Colide");
        if (other.gameObject.CompareTag("Player"))
        {
            print("Colide Player");
            if (isPonto)
            {
                var placar = FindAnyObjectByType<UI_Manager>();
                placar.AtualizarPontos(1);
                Destroy(gameObject);
            }
            else if (!isPonto)
            {
                var playerVidas = other.gameObject.GetComponent<PlayerVidas>();
                playerVidas.MudarVida(dano);
            }
        }
    }
}
