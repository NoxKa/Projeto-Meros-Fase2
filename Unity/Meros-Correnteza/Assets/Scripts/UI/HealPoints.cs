using UnityEngine;
using UnityEngine.UI;

public class HealPoints : MonoBehaviour
{
    [SerializeField] private Sprite[] pointSprites;
    private Image image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
    }
    public void SetPointSprite(int index)
    {
        image.sprite = pointSprites[index];
    }
}
