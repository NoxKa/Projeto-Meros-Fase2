using TMPro;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textVida;
    [SerializeField] private TextMeshProUGUI textPontos;
    [SerializeField] private TextMeshProUGUI textHeal;
    public GameObject splashUI;
    private int pontosAtual = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AtualizarVida(int vida)
    {
        if(textVida != null)
        {
            textVida.text = "Vida: "+vida.ToString();
        }
    }
    public void AtualizarPontos(int pontosObt)
    {
        pontosAtual += pontosObt;
        textPontos.text = pontosAtual.ToString();
    }
    public void HealPoints(int pontosHeal)
    {
        textHeal.text = pontosHeal.ToString();
    }
}
