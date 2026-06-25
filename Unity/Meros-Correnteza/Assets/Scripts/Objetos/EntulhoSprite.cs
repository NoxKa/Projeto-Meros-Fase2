using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public struct SpritesIndex
{
    public string cor;
    public Sprite sprite;
}
public class EntulhoSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Transform transforme;
    private int indice = 0;
    [SerializeField] SpritesIndex[] sprites;
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
            spriteRenderer.sprite = sprites[indice].sprite;
        }
    }
    public string CorSprite()
    {
        Debug.Log("Return "+sprites[indice].cor);
        return sprites[indice].cor;
    }
}
