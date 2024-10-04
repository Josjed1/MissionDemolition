using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float speed = 100f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, speed * Time.deltaTime);
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        transform.Rotate(Vector3.up, speed * Time.deltaTime);

    }
}
