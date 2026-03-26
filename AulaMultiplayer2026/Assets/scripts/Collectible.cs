using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 1;

    public float rotationspeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        RotateObject();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RotateObject()
    {
        transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime);
    }
}
