using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public GameObject scores;
    public GameObject resetMenu;
    public Text scoreText;
    public GameObject hiScore;
    // Start is called before the first frame update
    void Start()
    {
        resetMenu.SetActive(false);
        scores.SetActive(true);
    }

    public void death(int score, bool newScore)
    {
        scores.SetActive(false);
        resetMenu.SetActive(true);
        scoreText.text = "You scored: " + score;

        if(newScore == true)
        {
            hiScore.SetActive(true);
        }

        else
        {
            hiScore.SetActive(false);
        }
    }

    public void replay()
    {
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
