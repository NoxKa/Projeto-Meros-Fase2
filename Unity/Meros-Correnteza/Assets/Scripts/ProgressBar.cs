using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider progressBar;
    private float timeAtual;
    public float[] timeFases;
    public int faseAtual;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        progressBar.maxValue = timeFases[faseAtual-1];
    }

    // Update is called once per frame
    void Update()
    {
        timeAtual += Time.deltaTime;
        progressBar.value = timeAtual;
    }
}
