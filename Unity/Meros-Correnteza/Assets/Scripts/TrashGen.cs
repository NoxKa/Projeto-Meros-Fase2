using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class ObjectsObstaculos
{
    public string nome;
    public GameObject objectPrefab;
    public float tempoMed;
    public float tempoVariavel;
    public float tempoMin {get; private set;}
    public float tempoMax {get; private set;}
    public void StartObject()
    {
        tempoMin = tempoMed-tempoVariavel;
        tempoMax = tempoMed+tempoVariavel;
        if (tempoMin < 0)
        {
            tempoMin = 0;
        }
    }
}

public class TrashGen : MonoBehaviour
{
    [SerializeField] private List<ObjectsObstaculos> objetos;
    [SerializeField] private float genX; // Posição inicial X
    [SerializeField] private float genYrange; // Variação de altura (metade da tela)
    private int fase; // Numero da fase
    [SerializeField] private GameObject[] entulhosPrefabs; // Prefabs dos inimigos flutuantes
    [SerializeField] private GameObject splashUI;
    private float genY;
    void Start()
    {
        foreach(ObjectsObstaculos objeto in objetos)
        {
            objeto.StartObject();
        }
        StartCoroutine(GerarEntulhos());
        StartCoroutine(GerarTintas());
        StartCoroutine(GerarPontos());
        StartCoroutine(GerarRedes());
    }
    private IEnumerator GerarEntulhos() // Corrotina de geração de entulhos
    {
        ObjectsObstaculos entulho;
        entulho = GetObject("entulho");
        float genTime; // Intervalo de spawn
        while (entulho != null)
        {
            genTime = Random.Range(entulho.tempoMin, entulho.tempoMax); // Define um intervalo aleatorio
            yield return new WaitForSeconds(genTime);
            genY = Random.Range(-genYrange, genYrange); // Define a posição Y
            Instantiate(entulho.objectPrefab, new Vector2(genX, genY), entulho.objectPrefab.transform.rotation); // Instancia a prefab
        }
        Debug.Log("Entulho vazio");
    }
    private IEnumerator GerarTintas()
    {
        ObjectsObstaculos tinta;
        tinta = GetObject("tinta");
        float genTime; // Intervalo de spawn
        while (tinta != null)
        {
            genTime = Random.Range(tinta.tempoMin, tinta.tempoMax); // Define um intervalo aleatorio
            yield return new WaitForSeconds(genTime);
            genY = Random.Range(-genYrange, genYrange); // Define a posição Y
            GameObject instance = Instantiate(tinta.objectPrefab, new Vector2(genX, genY), tinta.objectPrefab.transform.rotation); // Instancia a prefab
            SplashColision splashColision = instance.GetComponent<SplashColision>();
            splashColision.Init(splashUI);
        }
        Debug.Log("Tinta vazio");
    }
    private IEnumerator GerarPontos() // Corrotina de geração de entulhos
    {
        ObjectsObstaculos ponto;
        ponto = GetObject("ponto");
        float genTime; // Intervalo de spawn
        while (ponto != null)
        {
            genTime = Random.Range(ponto.tempoMin, ponto.tempoMax); // Define um intervalo aleatorio
            yield return new WaitForSeconds(genTime);
            genY = Random.Range(-genYrange, genYrange); // Define a posição Y
            Instantiate(ponto.objectPrefab, new Vector2(genX, genY), ponto.objectPrefab.transform.rotation); // Instancia a prefab
        }
        Debug.Log("Ponto vazio");
    }
    private IEnumerator GerarRedes() // Corrotina de geração de entulhos
    {
        ObjectsObstaculos rede;
        rede = GetObject("rede");
        float genTime; // Intervalo de spawn
        while (rede != null)
        {
            genTime = Random.Range(rede.tempoMin, rede.tempoMax); // Define um intervalo aleatorio
            yield return new WaitForSeconds(genTime);
            genY = Random.Range(-genYrange, genYrange); // Define a posição Y
            Instantiate(rede.objectPrefab, new Vector2(genX, genY), rede.objectPrefab.transform.rotation); // Instancia a prefab
        }
        Debug.Log("Entulho vazio");
    }
    private ObjectsObstaculos GetObject(string alvo)
    {
        foreach (ObjectsObstaculos objeto in objetos)
        {
            if (objeto.nome == alvo)
            {
                return objeto;
            }
        }
        return null;
    }
}
