using UnityEngine;

public class PrendeCollider : MonoBehaviour
{
    public bool isDebativel; // Verifica se o player pode ativamente escapar
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMoviment playerMoviment = GameObject.Find("Player").GetComponent<PlayerMoviment>(); // Pega o script de movimento do player
            if (isDebativel)
            {
                playerMoviment.StopPlayer(true); // Imobiliza o player (pode se debater)
            }else
            {
                playerMoviment.StopPlayer(false); // Imobiliza o player (não pode se debater)
            }
            Destroy(this.gameObject);
        }
    }
}
