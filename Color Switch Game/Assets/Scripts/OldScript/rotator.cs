using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    private float speed ;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f, speed * Time.deltaTime);
    }

    public void SetSpeed(float rotation)
    {
        speed = rotation;
    }
}
