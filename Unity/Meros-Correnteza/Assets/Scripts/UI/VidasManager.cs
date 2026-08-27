using System.Collections.Generic;
using UnityEngine;

public class VidasManager : MonoBehaviour
{
    [SerializeField] private float yPosition;
    [SerializeField] private GameObject vidaPrefab;
    [SerializeField] private float xSpacing; // Espaçamento entre as vidas
    private List<GameObject> vidas = new List<GameObject>();
    public void Init(int vidasMax)
    {
        for (int i = 0; i < vidasMax; i+=2)
        {
            GameObject atualVidaObject = Instantiate(vidaPrefab, transform.parent);
            vidas.Add(atualVidaObject);
            
            //atualVidaObject.transform.position = transform.position;
            //atualVidaObject.transform.position = new Vector2(atualVidaObject.transform.position.x + vidas.Count * xSpacing, atualVidaObject.transform.position.y);
        }
    }
}

/*RectTransform rect = atualVidaObject.GetComponent<RectTransform>();

rect.anchoredPosition = new Vector2(
    i * xSpacing,
    yPosition
);*/
