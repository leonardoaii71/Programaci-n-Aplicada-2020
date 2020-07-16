using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollController : MonoBehaviour
{
    MeshRenderer renderer;
    float scrollSpeedX = 0.3f;
    Vector2 currentPosition = Vector2.zero;
    void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
         currentPosition.x += scrollSpeedX * Time.deltaTime;
        renderer.material.mainTextureOffset = currentPosition;
    }
}
