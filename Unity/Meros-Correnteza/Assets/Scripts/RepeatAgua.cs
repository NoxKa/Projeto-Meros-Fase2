using UnityEngine;

public class RepeatAgua : MonoBehaviour
{
    private float startPositionX;
    private float largura;
    void Awake()
    {
        startPositionX = transform.position.x;
        
    }
    void Start()
    {
        //screenWidth = Camera.main.orthographicSize * 2f * Camera.main.aspect;
        largura = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPositionX-largura/3)
        {
            transform.position = new Vector2(startPositionX, transform.position.y);
        }
    }
}
