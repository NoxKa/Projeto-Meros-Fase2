using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int faseAtual;
    [SerializeField] private int faseTest;
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
        if (faseAtual == 0)
        {
            faseAtual = faseTest;
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
