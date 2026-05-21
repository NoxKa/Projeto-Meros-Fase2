using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] int speedX; // Velocidade
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speedX); // Translata para a esquerda
    }
}
