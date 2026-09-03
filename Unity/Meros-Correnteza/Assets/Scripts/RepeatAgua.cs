using UnityEngine;

public class RepeatAgua : MonoBehaviour
{
    private float screenWidth;
    private float startPositionX;
    void Start()
    {
        startPositionX = transform.position.x;
        screenWidth = Camera.main.orthographicSize * 2f * Camera.main.aspect;
        Debug.Log(screenWidth);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPositionX-screenWidth)
        {
            transform.position = new Vector2(startPositionX, transform.position.y);
            Debug.Log("Repeat");
        }
    }
}
