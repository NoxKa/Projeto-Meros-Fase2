using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VidasManager : MonoBehaviour
{
    [SerializeField] private float yPosition;
    [SerializeField] private float xPosition;
    [SerializeField] private GameObject vidaPrefab;
    [SerializeField] private float xSpacing; // Espaçamento entre as vidas
    private List<GameObject> vidas = new List<GameObject>();
    public void Init(int vidasMax)
    {
        for (int i = 0; i < vidasMax; i+=2)
        {
            GameObject atualVidaObject = Instantiate(vidaPrefab, transform.parent);
            vidas.Add(atualVidaObject);
            RectTransform rect = atualVidaObject.GetComponent<RectTransform>();
            rect.anchoredPosition = new Vector2(xPosition-(vidas.Count-1) * xSpacing, yPosition);
        }
    }
    public void SetVida(int vidaMax, int vidaAtual)
    {
        int index;
        Animator vidaAnimator;
        /*foreach(GameObject vida in vidas)
        {
            vidaAnimator = GetComponent<Animator>();
            vidaAnimator.SetInteger("vidas", vidaAtual/3);
        }*/
        for (int i = 0; i<vidaMax; i++)
        {
            index = i/2;
            Debug.Log(index);
            //vidaAnimator = vidas[index].GetComponent<Animator>();
            //vidaAnimator.SetInteger("vidas", );
        }
    }
}
