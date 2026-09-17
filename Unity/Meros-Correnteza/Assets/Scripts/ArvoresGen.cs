using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class ArvoresGen : MonoBehaviour
{
    [SerializeField] private float genX; // Posição inicial X
    [SerializeField] private float startX;
    [SerializeField] private Vector2 genYrange = new Vector2(); // Variação de altura (x = min, y = max)
    [SerializeField] private GameObject arvorePrefab;
    [SerializeField] private Vector2 genMedDistance = new Vector2();
    private bool genAutomaticaOn = false;
    private float genDistance = 1;
    private GameObject lastTree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartArvores();
    }
    public void FixedUpdate()
    {
        if (genDistance < genX-lastTree.transform.position.x && genAutomaticaOn)
        {
            GerarArvore(genX);
        }
        startX += Time.fixedDeltaTime;
    }

    private void GerarArvore(float startPositionX)
    {
        Debug.Log("Avore");
        float genY = Random.Range(genYrange.x, genYrange.y);
        lastTree = Instantiate(arvorePrefab, new Vector2(startPositionX, genY), arvorePrefab.transform.rotation); // Instancia a prefab
        genDistance = Random.Range(genMedDistance.x, genMedDistance.y);
    }
    private void StartArvores()
    {
        while (startX < genX)
        {
            GerarArvore(startX);
            startX += genDistance;
        }
        genAutomaticaOn = true;
        Debug.Log("Start");
    }
}
