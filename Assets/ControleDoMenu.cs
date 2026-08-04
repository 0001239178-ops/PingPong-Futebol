using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleDoMenu : MonoBehaviour
{

    public void IniciarJogo()
    {
        SceneManager.LoadScene("CenaJogo");
    }

    public void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("O jogo fechou!");
    }

    public void ReiniciarPartida()
    {
        SceneManager.LoadScene("CenaJogo");
    }

    public void IrParaOMenu()
    {
        SceneManager.LoadScene("MenuInicial");
    }






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
