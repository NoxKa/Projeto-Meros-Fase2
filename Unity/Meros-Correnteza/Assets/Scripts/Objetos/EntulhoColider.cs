using Unity.VisualScripting;
using UnityEngine;

public class EntulhoColider : MonoBehaviour
{
    public int dano;
    public bool isPonto;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var playerVidas = other.gameObject.GetComponent<PlayerVidas>();
            var placar = FindAnyObjectByType<UI_Manager>();
            if (isPonto)
            {
                placar.AtualizarPontos(1);
                playerVidas.HealPoints(1);
                Destroy(gameObject);
            }
            else if (!isPonto)
            {
                playerVidas.MudarVida(-dano);
            }
        }
    }
}
