using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SplashAnim : MonoBehaviour
{
    private Image image;
    [SerializeField] private SpritesIndex[] sprites;
    public void OnFinishAnimation() // Desativa o splash quando acaba a animação
    {
        gameObject.SetActive(false);
    }
    public void CorTinta(string cor)
    {
        image = GetComponent<Image>();
        foreach (SpritesIndex indice in sprites)
        {
            if(indice.cor == cor)
            {
                image.sprite = indice.sprite;
                return;
            }
        }
    }
}
