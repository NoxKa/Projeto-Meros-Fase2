using UnityEngine;
using System.Collections;

public class TrashGen : MonoBehaviour
{
    public float genX;
    public float genYrange;
    private int fase;
    public GameObject[] entulhosPrefabs;
    public GameObject pontosPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(GerarEntulhos());
        StartCoroutine(GerarPontos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator GerarEntulhos()
    {
        float genY;
        int entulhosIndex;
        float genTime;
        while (true)
        {
            genTime = Random.Range(1, 8);
            yield return new WaitForSeconds(genTime);
            entulhosIndex = Random.Range(0, entulhosPrefabs.Length);
            genY = Random.Range(-genYrange, genYrange);
            Instantiate(entulhosPrefabs[entulhosIndex], new Vector2(genX, genY), entulhosPrefabs[entulhosIndex].transform.rotation);
        }
    }
    private IEnumerator GerarPontos()
    {
        float genY;
        float genTime;
        while (true)
        {
            genTime = Random.Range(5, 10);
            yield return new WaitForSeconds(genTime);
            genY = Random.Range(-genYrange, genYrange);
            Instantiate(pontosPrefabs, new Vector2(genX, genY), pontosPrefabs.transform.rotation);
        }
    }
}
