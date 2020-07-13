using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehavior : MonoBehaviour
{
    GameObject center;
    float currentDistance, scalarAcceleration = 2f, shootingTime;
    Vector3 currentPosition = new Vector3(), angle;
    Vector3 currentSpeed = Vector3.zero;
    
    // Update is called once per frame
    void Update()
    {
        angle = currentSpeed * (Time.deltaTime - shootingTime) / currentDistance;
        currentPosition.x = center.transform.position.x + currentDistance * Mathf.Cos(angle.x);
        currentPosition.y = center.transform.position.y + currentDistance * Mathf.Sin(angle.y);
        transform.position = currentPosition;

        currentSpeed.x += scalarAcceleration * Time.deltaTime;
        currentSpeed.y += scalarAcceleration * Time.deltaTime;
    }
    public void Shoot(GameObject center, float distance){
        this.center = center;
        currentDistance = distance;
        shootingTime = Time.time;
    }

}
