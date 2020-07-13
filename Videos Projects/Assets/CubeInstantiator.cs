using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeInstantiator : MonoBehaviour
{
    public GameObject[] Cubes;
    Vector3 startingPosition = new Vector3(0, 7.5f);
    float nextTime;
    const float MIN_TIME = 0.2f, MAX_TIME = 1.5f, MIN_X = -8, MAX_X = 8;

    private void Start() {
        nextTime = GetNextTime();
    }

    private void Update() {
        if (Time.time > nextTime)
        {
            startingPosition.x = UnityEngine.Random.Range(MIN_X, MAX_X);
            Instantiate(GetCube(), startingPosition, Quaternion.identity);
            nextTime = GetNextTime();
        }
    }

    private float GetNextTime() {
        return Time.time + UnityEngine.Random.Range(MIN_TIME, MAX_TIME);   
    }
    private GameObject GetCube() {
        return Cubes[Random.Range(0, Cubes.Length)];
    }
}
