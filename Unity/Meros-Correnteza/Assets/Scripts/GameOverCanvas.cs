using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCanvas : MonoBehaviour
{
    public void VoltarAoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ReiniciarFase()
    {
        SceneManager.LoadScene("Fase"+GameManager.Instance.GetFase());
    }
}
