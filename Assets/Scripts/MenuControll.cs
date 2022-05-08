using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControll : MonoBehaviour
{

    [SerializeField] private Button _buttonStart;
    [SerializeField] private Button _buttonExit;
    [SerializeField] private Button _buttonBack;
    [SerializeField] private Button _restartGame;

    private void Start()
    {
        _buttonStart.onClick.AddListener(StartGame);
        _buttonExit.onClick.AddListener(ExitGame);
        _buttonBack.onClick.AddListener(BackToMenu);
        _restartGame.onClick.AddListener(RestartGame);
    }

    public void StartGame()
    {
        Debug.Log("START GAME");
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("EXIT GAME");
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
