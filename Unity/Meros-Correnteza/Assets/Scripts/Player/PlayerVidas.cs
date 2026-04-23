using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using System.Collections;

public class PlayerVidas : MonoBehaviour
{
    public int vidaMax;
    private int vidaAtual;
    private int pontosHealMax = 3;
    private int pontosHeal = 0;
    private bool imortal = false;
    private Animator playerAnim;
    private UI_Manager placar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaAtual = vidaMax;
        playerAnim = GetComponent<Animator>();
        placar = FindAnyObjectByType<UI_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MudarVida(int vidaMod)
    {
        if (!imortal)
        {
            vidaAtual += vidaMod;
            imortal = true;
            placar.AtualizarVida(vidaAtual);
            if (vidaMod < 0)
            {
                StartCoroutine(Imortal());
            }
        }
    }
    private IEnumerator Imortal()
    {
        float tempoImortal = 2;
        playerAnim.SetBool("isFlashed", true);
        yield return new WaitForSeconds(tempoImortal);
        imortal = false;
        playerAnim.SetBool("isFlashed", false);
    }
    public void HealPoints(int pontos)
    {
        pontosHeal += pontos;
        if (pontosHeal >= pontosHealMax)
        {
            pontosHeal = 0;
            if (vidaAtual < vidaMax)
            {
                MudarVida(1);
            }
        }
        placar.HealPoints(pontosHeal);
    }
}
