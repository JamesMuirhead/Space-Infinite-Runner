using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{

    public GameObject rockPrefab;
    private float maxX, maxY, minX, minY;
    private float waveSize = 40f;

    public void StartSpawning(Vector2 bottomCorner, Vector2 topCorner)
    {
        minX = bottomCorner.x;
        maxX = topCorner.x;
        minY = bottomCorner.y;
        maxY = topCorner.y;

        StartCoroutine(rockSpawn());
    }
    
    IEnumerator rockSpawn()
    {
        Vector3 spawnPos;
        float rockScale;

        while (true)
        {
            while(transform.childCount < waveSize)
            {
                spawnPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), transform.position.z);
                rockScale = Random.Range(1, 6);
                GameObject newRock = Instantiate(rockPrefab, spawnPos, transform.rotation, transform);
                newRock.transform.localScale = new Vector3(rockScale, rockScale, rockScale);
                yield return new WaitForSeconds(rockScale / MeteorMove.gameSpeed * -1);
            }

            yield return new WaitForSeconds(5f);
        }
    }
}
