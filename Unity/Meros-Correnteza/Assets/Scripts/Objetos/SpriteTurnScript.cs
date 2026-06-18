using UnityEngine;

public class SpriteTurnScript : MonoBehaviour
{
    private Transform transforme;
    private int rotar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotar = Random.Range(0, 360);
        transforme = GetComponent<Transform>();
        transforme.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, rotar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
