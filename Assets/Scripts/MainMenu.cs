using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        PlayerPrefs.SetInt("_enemyScore", 0);
        PlayerPrefs.SetInt("_playerScore", 0);
        Score._playerScore = 0;
        Score._enemyScore = 0;
        SceneManager.LoadScene(1);
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }


}
