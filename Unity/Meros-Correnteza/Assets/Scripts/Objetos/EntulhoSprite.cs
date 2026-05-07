using UnityEngine;

public class EntulhoSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Transform transforme;
    [SerializeField] Sprite[] sprites;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        transforme = GetComponent<Transform>();
        SetSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetSprite()
    {
        if (sprites.Length > 0)
        {
            int indice = Random.Range(0, sprites.Length);
            spriteRenderer.sprite = sprites[indice];
        }
        int rotar = Random.Range(0, 360);
        transforme.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, rotar);
    }
}
