using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonLayerController : MonoBehaviour
{
    MeshRenderer renderer;
    float scrollSpeedX = 0.8f, currentSpeed;
    Vector2 currentPosition = new Vector2();
  
    void Update()
    {
        currentPosition.x = -scrollSpeedX * Time.deltaTime;
        transform.Translate(currentPosition); 
        
    }
}
