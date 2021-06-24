using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChange : MonoBehaviour
{
    private bool alive;
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        MeteorMove.gameSpeed = -5;
        StartCoroutine(increaseSpeed());
    }
    public void death()
    {
        alive = false;
    }

    IEnumerator increaseSpeed()
    {
        while (alive)
        {
            for(int i = 0; i < 5; i++)
            {
                yield return new WaitForSeconds(5f);
                MeteorMove.gameSpeed -= 1;
            }
            
            yield return new WaitForSeconds(-1 * MeteorMove.gameSpeed);
        }
    }
}
