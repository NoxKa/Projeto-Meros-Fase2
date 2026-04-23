using UnityEngine;

public class PrendeCollider : MonoBehaviour
{
    public bool isDebativel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMoviment playerMoviment;
            playerMoviment = GameObject.Find("Player").GetComponent<PlayerMoviment>();
            if (isDebativel)
            {
                playerMoviment.StopPlayer(true);
            }else
            {
                playerMoviment.StopPlayer(false);
            }
            Destroy(this.gameObject);
        }
    }
}
