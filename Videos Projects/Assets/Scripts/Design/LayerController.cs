using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{
    
    MeshRenderer renderer;
    float scrollSpeedX = 0.15f, currentSpeed;
    Vector2 currentPosition = Vector2.zero;
    void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        currentSpeed = scrollSpeedX * (20 / gameObject.transform.position.z);
         currentPosition.x += scrollSpeedX * Time.deltaTime;
        renderer.material.mainTextureOffset = currentPosition;
    }
}
