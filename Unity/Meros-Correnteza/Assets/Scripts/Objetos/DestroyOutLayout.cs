using UnityEngine;

public class DestroyOutLayout : MonoBehaviour
{
    [SerializeField] private float maxX = -15; // Valor limite de X
    void Update()
    {
        if (transform.position.x < maxX)
        {
            Destroy(gameObject);
        }
    }
}
