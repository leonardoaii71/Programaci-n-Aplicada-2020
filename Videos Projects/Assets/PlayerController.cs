using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speedY = 5f;
    Vector3 deltaPos = new Vector3();

    const float MIN_Y = -4.31f, MAX_Y = 4.31f, MIN_X = -8f, MAX_X = 8f;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchSupported && Input.touchCount > 0)
        {
            deltaPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            deltaPos *= speedY;
            deltaPos *= Time.deltaTime;
            transform.Translate(deltaPos);
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, MIN_X, MAX_X),
                Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y),
                0
            );
        }
    }
}