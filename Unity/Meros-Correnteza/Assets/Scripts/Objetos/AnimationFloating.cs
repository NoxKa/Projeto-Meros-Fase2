using NUnit.Framework;
using UnityEngine;

public class AnimationFloating : MonoBehaviour
{
    [SerializeField] private float rangeY;
    [SerializeField] private float rangeSpeedY;
    private float speedY;
    private Vector2 startPosition = new Vector2();
    private bool isSubindo = true;
    
    void Start()
    {
        startPosition = transform.position;
        speedY = Random.Range(0.2f-rangeSpeedY, 0.2f+rangeSpeedY);
        isSubindo = Random.Range(0, 2) == 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSubindo)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speedY);
            if (transform.position.y > startPosition.y + rangeY)
            {
                isSubindo = false;
            }
        }else
        {
            transform.Translate(Vector2.down * Time.deltaTime * speedY);
            if (transform.position.y < startPosition.y - rangeY)
            {
                isSubindo = true;
            }
        }
    }
}
