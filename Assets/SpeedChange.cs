using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeteorMove.gameSpeed = -5;
        StartCoroutine(increaseSpeed());
    }

    IEnumerator increaseSpeed()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            MeteorMove.gameSpeed -= 1;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
