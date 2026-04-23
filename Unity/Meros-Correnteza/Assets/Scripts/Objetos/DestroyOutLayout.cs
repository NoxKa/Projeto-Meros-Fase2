using UnityEngine;

public class DestroyOutLayout : MonoBehaviour
{
    private float maxX = -15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < maxX)
        {
            Destroy(this.gameObject);
        }
    }
}
