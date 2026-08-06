using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject menuMain;


    public void Jogar()
    {
        GameManager.Instance.ChangeFase(1);
        SceneManager.LoadScene("Fase1"); // Inicia fase 1
    }
    public void  OnMenu(GameObject menu)
    {
        menuMain.SetActive(false);
        menu.SetActive(true);
    }
    public void offMenu(GameObject menu)
    {
        menu.SetActive(false);
        menuMain.SetActive(true);
    }
    public void Sair()
    {
        Debug.Log("Sair");
    }
}
