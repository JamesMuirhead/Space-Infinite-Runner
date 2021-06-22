using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        StartCoroutine(scoreCounter());
    }

    IEnumerator scoreCounter()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            score += Mathf.RoundToInt(MeteorMove.gameSpeed) * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score + " METRES";
    }
}
