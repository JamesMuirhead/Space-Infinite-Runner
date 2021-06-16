using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    public static float gameSpeed = - 5;
    private float moveAmount, mySpeed, tumble;
    private Rigidbody rb3d;
    // Start is called before the first frame update
    void Start()
    {
        rb3d = GetComponent<Rigidbody>();
        mySpeed = gameSpeed + Random.Range(gameSpeed, 0);
        tumble = Random.Range(-1, 1);

        rb3d.AddForce(new Vector3(0, 0, mySpeed), ForceMode.VelocityChange);

        transform.rotation = Random.rotation;
        rb3d.angularVelocity = Random.insideUnitSphere * tumble;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -7f)
        {
            Destroy(gameObject);
        }
    }
}
