using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController2Axis : MonoBehaviour
{
    Vector3 movementSpeed = new Vector3(20, 20);
    Vector3 deltaPos = new Vector3();
    const float MIN_Y = -4.31f, MAX_Y = 4.31f, MIN_X = -8.20f, MAX_X = 8.20f;

    // Update is called once per frame
    void Update()
    {
        deltaPos.y = Input.GetAxis("Vertical") * movementSpeed.y;
        deltaPos.x = Input.GetAxis("Horizontal") * movementSpeed.x;
        deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(deltaPos);

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, MIN_X, MAX_X),
            Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y)
        );
    }
}

