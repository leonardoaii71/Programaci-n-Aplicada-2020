using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooterController : MonoBehaviour
{
    public GameObject Munition;
    public GameObject Shield;
    Vector3 initialVelocity;
    const float speed = 20f;
    float angle, deltaY, deltaX;
    Vector3 userInput = new Vector3();
    const float shieldDistance = 2f;

    void Start()
    {
        initialVelocity = new Vector3(speed, speed);
    }

    void Update()
    {
        if (Input.touchSupported && Input.touchCount > 0)
            userInput = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        userInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        deltaY = userInput.y - transform.position.y;
        deltaX = userInput.x - transform.position.x;

        angle = Mathf.Atan(deltaY / deltaX);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Munition, transform.position, Quaternion.identity)
                .GetComponent<Munition>().Shoot(initialVelocity, angle);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(Shield, transform.position, Quaternion.identity)
                .GetComponent<ShieldBehavior>().Shoot(gameObject, shieldDistance);
        }

    }
}
