using UnityEngine;

public class BackGroundReset : MonoBehaviour
{
    private float minX;
    [SerializeField] private Vector2 variavelX = new Vector2();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("");
        if (transform.position.x < variavelX.x)
        {
            transform.position = new Vector3 (variavelX.y, transform.position.y);
        }
    }
}
