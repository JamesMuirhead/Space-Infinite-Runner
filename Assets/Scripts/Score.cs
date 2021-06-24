using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    public Text text1;
    public int score;
    private bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        alive = true;

        if (PlayerPrefs.HasKey("highScore") == false)
        {
            PlayerPrefs.SetFloat("highScore", 0f);
        }

        text1.text = "HI-SCORE " + PlayerPrefs.GetFloat("highScore");
        score = 0;
        StartCoroutine(scoreCounter());
    }

    IEnumerator scoreCounter()
    {
        while (alive == true)
        {
            yield return new WaitForSeconds(0.1f);
            score += Mathf.RoundToInt(MeteorMove.gameSpeed) * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score + " POINTS";
    }
}
