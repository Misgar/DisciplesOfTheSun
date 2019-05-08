using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //Variável booleana que define se o jogo está pausado de fato
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public string scene;
        
    // Update is called once per frame
    void Update()
    {
    //Se a tecla esc for presionada
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
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    void Pause()
    {
        //Ativando a UI de menu pausado
        pauseMenuUI.SetActive(true);
        //Define a velocidade que o game passará. No causa de Pause, o tempo deve parar totalmente
        Time.timeScale = 0f;
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
