using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem.iOS;

public class TrashGen : MonoBehaviour
{
    public float genX; // Posição inicial X
    public float genYrange; // Variação de altura (metade da tela)
    private int fase; // Numero da fase
    public GameObject[] entulhosPrefabs; // Prefabs dos inimigos flutuantes
    private float lastY;
    void Start()
    {
        StartCoroutine(GerarEntulhos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator GerarEntulhos() // Corrotina de geração de entulhos
    {
        float genY; // Posição inicial Y
        int entulhosIndex; // Tipo de entulho
        float genTime; // Intervalo de spawn
        //int chance; // Fazer chance
        //Debug.Log(chance);
        while (true)
        {
            genTime = Random.Range(1, 3); // Define um intervalo aleatorio
            yield return new WaitForSeconds(genTime);
            entulhosIndex = Random.Range(0, entulhosPrefabs.Length); // Define o tipo de entulhoe (de 0 até o tamanho da lista)
            genY = Random.Range(-genYrange, genYrange); // Define a posição Y
            Instantiate(entulhosPrefabs[entulhosIndex], new Vector2(genX, genY), entulhosPrefabs[entulhosIndex].transform.rotation); // Instancia a prefab
        }
    }
}
