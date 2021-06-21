using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed, offset;
    public SpawnControl spawnControl;
    private float minX, maxX, minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        minX = bottomCorner.x;
        maxX = topCorner.x;
        minY = bottomCorner.y;
        maxY = topCorner.y;

        spawnControl.StartSpawning(bottomCorner, topCorner);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = Input.mousePosition;
        temp.z = 10f;
        temp = Camera.main.ScreenToWorldPoint(temp);
        temp.x = Mathf.Clamp(temp.x, minX, maxX);
        temp.y = Mathf.Clamp(temp.y, minY, maxY);
        temp.z = 0f;
        Vector3 moveTo = temp - transform.position;
        transform.Translate(moveTo * Time.deltaTime * moveSpeed);

        float pitch, roll;

        if (moveTo.x > 1)
        {
            roll = -20f;
        }

        else if (moveTo.x < -1)
        {
            roll = 20f;
        }

        else
        {
            roll = 0f;
        }

        if (moveTo.y > 1)
        {
            pitch = -25f;
        }

        else if (moveTo.y < -1)
        {
            pitch = 25f;
        }

        else
        {
            pitch = 0f;
        }

        Quaternion targetAngle = Quaternion.Euler(pitch, 0, roll);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetAngle, Time.deltaTime * 2f);
    }
}
