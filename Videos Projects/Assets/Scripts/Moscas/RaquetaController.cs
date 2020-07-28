using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaquetaController : MonoBehaviour
{
    private Vector3 deltaPos;
    public AudioSource hit;
    public float movSpeed = 10f;
    // Start is called before the first frame update

    void Start()
    {
     hit = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        deltaPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        deltaPos.z = 0;
            //deltaPos *= movSpeed;
            //deltaPos *= Time.deltaTime;
            transform.position = deltaPos;
            /*transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, MIN_X, MAX_X),
                Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y),
                0
            );*/
    }
    private void OnTriggerEnter(Collider other) {
        hit.Play();
    }
}
