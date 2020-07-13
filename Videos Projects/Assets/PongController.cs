using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongController : MonoBehaviour
{
    const float Max_Y = 8f;
    Vector3 currentPosition = new Vector3();
    const float SPEED_Y = 15f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition.y = -4 + Mathf.PingPong(Time.time * SPEED_Y, Max_Y);
        transform.position = currentPosition;
    }
}
