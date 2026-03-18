using UnityEngine;
using System.Collections;

public class TrashGen : MonoBehaviour
{
    public float genX;
    private int fase;
    public GameObject[] entulhosPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(GerarEntulhos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator GerarEntulhos()
    {
        float genY;
        int entulhosIndex;
        while (true)
        {
            yield return new WaitForSeconds(3);
            entulhosIndex = Random.Range(0, entulhosPrefabs.Length);
            genY = Random.Range(-4f, 4f);
            Instantiate(entulhosPrefabs[entulhosIndex], new Vector2(genX, genY), entulhosPrefabs[entulhosIndex].transform.rotation);
        }
    }
}
