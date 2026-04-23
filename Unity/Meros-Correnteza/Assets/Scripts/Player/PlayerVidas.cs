using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using System.Collections;

public class PlayerVidas : MonoBehaviour
{
    public int vidaMax;
    private int vidaAtual;
    private bool imortal = false;
    private Animator playerAnim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaAtual = vidaMax;
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MudarVida(int vidaMod)
    {
        if (!imortal)
        {
            var placar = FindAnyObjectByType<UI_Manager>();
            vidaAtual -= vidaMod;
            imortal = true;
            placar.AtualizarVida(vidaAtual);
            StartCoroutine(Imortal());
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
}
