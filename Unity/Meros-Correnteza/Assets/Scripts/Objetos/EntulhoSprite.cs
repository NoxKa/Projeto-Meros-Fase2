using UnityEngine;

public class EntulhoSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Transform transforme;
    [SerializeField] Sprite[] sprites;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        transforme = GetComponent<Transform>();
        SetSprite();
    }
    private void SetSprite()
    {
        if (sprites.Length > 0)
        {
            int indice = Random.Range(0, sprites.Length);
            spriteRenderer.sprite = sprites[indice];
        }
    }
}
