using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenus : MonoBehaviour
{

    public void NavegacionSeguraScene()
    {
        SceneManager.LoadScene("Navegación_segura");
    }
    public void AdiccionDispositivosScene()
    {
        SceneManager.LoadScene("Adiccion_dispositivos");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
