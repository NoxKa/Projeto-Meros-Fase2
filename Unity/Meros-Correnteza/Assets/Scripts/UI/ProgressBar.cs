using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Slider progressBar; // Slider da progressBar
    private float timeAtual; // Tempo que já passou
    [SerializeField] private float timeFase; // Tempo da fase
    private InputAction skip;
    void Awake()
    {
        skip = InputSystem.actions.FindAction("Sheet");
    }
    void Start()
    {
        progressBar.maxValue = timeFase; // Define o valor máximo para o tempo da fase atual
    }
    void Update()
    {
        timeAtual += Time.deltaTime; // Adiciona o tempo
        progressBar.value = timeAtual; // Define o progresso da barra pelo tempo que passou
        if(progressBar.value >= progressBar.maxValue)
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.ChangeFase(GameManager.Instance.GetFase()+1);
                if (GameManager.Instance.GetFase() < 4)
                {
                    SceneManager.LoadScene("Fase"+GameManager.Instance.GetFase());
                }
                else
                {
                    SceneManager.LoadScene("win");
                }
            }
        }
        if (skip.WasPressedThisFrame())
        {
            timeAtual = timeFase;
        }
    }
}
