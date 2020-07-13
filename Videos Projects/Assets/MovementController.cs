using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    
    float speedY = 20f;
    Vector3 deltaPos = new Vector3();
    const float MIN_Y = -4.31f, MAX_Y = 4.31f;

    // Update is called once per frame
    void Update()
    {
        deltaPos.y = Input.GetAxis("Vertical") * speedY * Time.deltaTime;
        transform.Translate(deltaPos);
        transform.position = new Vector3(
            gameObject.transform.position.x,
            Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y)
        );
    }
}
