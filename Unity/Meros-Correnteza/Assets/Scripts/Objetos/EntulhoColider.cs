using Unity.VisualScripting;
using UnityEngine;

public class EntulhoColider : MonoBehaviour
{
    public int dano;
    public bool isPonto;
    public int typeOfTrapped; // (0: não prende o jogador, 1: prende ele por alguns segundos, 2: prende ele até ele se soltar)
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
