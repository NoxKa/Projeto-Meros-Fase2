using UnityEngine;

public class EntulhoColider : MonoBehaviour
{
    [SerializeField] private int dano; // Dano do entulho
    [SerializeField] private bool isPonto; // Verifica se é um ponto

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var playerVidas = other.gameObject.GetComponent<PlayerVidas>(); // Pega o script de vidas do player
            var placar = FindAnyObjectByType<UI_Manager>(); // Pega o script do placar
            if (isPonto)
            {
                placar.AtualizarPontos(1); // Altera o UI de ponto
                playerVidas.HealPoints(1); // Aumenta o valor de "regeneração" no script de vida
                Destroy(gameObject);
            }
            else if (!isPonto)
            {
                playerVidas.MudarVida(-dano); // Altera a vida do player nos scipt dele
                Destroy(gameObject);
            }
        }
    }
}
