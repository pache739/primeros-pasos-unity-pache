using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void CargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}

//Cargar una escena o un nivel
//Reiniciar el juego o el nivel 
//salir del juego
//pausar el juego