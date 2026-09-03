using UnityEngine.UI;
using UnityEngine;

public class VidaInt : MonoBehaviour
{
    private Image image;
    [SerializeField] private bool mirroed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
        if (mirroed)
        {
            image.rectTransform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
