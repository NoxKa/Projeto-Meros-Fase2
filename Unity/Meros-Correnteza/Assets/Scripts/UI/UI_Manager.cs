using TMPro;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textVida; // Text de vida
    [SerializeField] private TextMeshProUGUI textPontos; // Text de pontos
    [SerializeField] private TextMeshProUGUI textHeal; // Text de "regeneração"

    private int pontosAtual = 0;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void AtualizarVida(int vida) // Altera o texto de vida
    {
        if(textVida != null)
        {
            textVida.text = "Vida: "+vida.ToString();
        }
    }
    public void AtualizarPontos(int pontosObt) // Atualiza e altera o texto de pontos
    {
        pontosAtual += pontosObt; // Soma os pontos
        textPontos.text = pontosAtual.ToString(); // Altera o texto
    }
    public void HealPoints(int pontosHeal) // Altera o texto de regeneração (baseado no playerVidas)
    {
        textHeal.text = pontosHeal.ToString();
    }
}
