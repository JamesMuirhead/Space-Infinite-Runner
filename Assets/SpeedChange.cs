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
            for(int i = 0; i < 5; i++)
            {
                yield return new WaitForSeconds(5f);
                MeteorMove.gameSpeed -= 1;
                Debug.Log(MeteorMove.gameSpeed);
            }
            
            yield return new WaitForSeconds(-1 * MeteorMove.gameSpeed);
            Debug.Log("Yeet");
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
