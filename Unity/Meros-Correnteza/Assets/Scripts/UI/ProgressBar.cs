using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Slider progressBar; // Slider da progressBar
    private float timeAtual; // Tempo que já passou
    [SerializeField] private float[] timeFases; // Tempo de cada fase
    [SerializeField] private int faseAtual; // Fase atual
    void Start()
    {
        progressBar.maxValue = timeFases[faseAtual-1]; // Define o valor máximo para o tempo da fase atual
    }
    void Update()
    {
        timeAtual += Time.deltaTime; // Adiciona o tempo
        progressBar.value = timeAtual; // Define o progresso da barra pelo tempo que passou
    }
}
