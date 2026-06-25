using UnityEngine;

public class SplashAnim : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private SpritesIndex[] sprites;
    public void OnFinishAnimation() // Desativa o splash quando acaba a animação
    {
        gameObject.SetActive(false);
    }
    public void CorTinta(string cor)
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log("Chamada "+cor);
        Debug.Log(spriteRenderer);
        foreach (SpritesIndex indice in sprites)
        {
            Debug.Log(indice.cor);
            if(indice.cor == cor)
            {
                Debug.Log("Troca");
                spriteRenderer.sprite = indice.sprite;
                return;
            }
        }
    }
}
