using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //Variáveis do pause
    public Button newGameButton;
    public Button optionsButton;
    public Button exitGameButton;
    public string newGameSceneName;
    public GameObject optionsMenu;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void Awake()
    {
        newGameButton.onClick.AddListener(NewGame);
        optionsButton.onClick.AddListener(OptionsGame);
        exitGameButton.onClick.AddListener(ExitGame);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameSceneName);
    }

    public void OptionsGame()
    {
        optionsMenu.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}

