using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int faseAtual;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    public void ChangeFase(int fase)
    {
        faseAtual = fase;
    }
    public int GetFase()
    {
        return faseAtual;
    }
}
