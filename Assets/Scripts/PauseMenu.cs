using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    //Variável booleana que define se o jogo está pausado de fato
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public string scene;
        
    void Update()
    {
    //Se a tecla esc for pressionada
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        //Se o jogo já está pausado
            if (GameIsPaused)
            {
                Resume();
            }
                else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        //Desativa a UI de menu pausado
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1;
    }

    public void Pause()
    { 
        pauseMenuUI.SetActive(true);
        //Define a velocidade que o game passará. No caso de Pause, o tempo deve parar totalmente
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
