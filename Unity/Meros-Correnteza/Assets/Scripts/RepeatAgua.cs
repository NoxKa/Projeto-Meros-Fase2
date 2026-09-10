using UnityEngine;

public class RepeatAgua : MonoBehaviour
{
    private float screenWidth;
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
        Debug.Log(screenWidth);
        Debug.Log(startPositionX);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPositionX-largura/3)
        {
            Debug.Log(transform.position.x);
            transform.position = new Vector2(startPositionX, transform.position.y);
            Debug.Log("Repeat");
        }
    }
}
