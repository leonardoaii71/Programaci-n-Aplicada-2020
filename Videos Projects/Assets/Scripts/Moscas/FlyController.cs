using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour
{
     Vector3 speed = new Vector3();
    Vector3 acceleration = new Vector3(10, 0, 0);
    const float  MIN_Y = -4.6f, MAX_Y = 4.6f, MIN_X = -2.4f, MAX_X = 2.4f;
    bool RTL = true;
     LevelMaganer levelMaganer;

    // Start is called before the first frame update
    void Start()
    {
       
    }
     private void Awake() {
        levelMaganer = GameObject.Find("LevelManager").GetComponent<LevelMaganer>();
    }

    // Update is called once per frame
    void Update()
    {
        
         gameObject.transform.Translate(MUUR());
          transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, MIN_X, MAX_X),
            Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y)
        );
    }

    public Vector3 MUUR(){
        if(transform.position.x == MAX_X && RTL){
            RTL = !RTL;
            acceleration = -1 * acceleration;
        }
        else if(transform.position.x == MIN_X && !RTL){
            RTL = !RTL;
            acceleration = -1 * acceleration;
        }
        
        Vector3 deltaPos =  speed * Time.deltaTime + acceleration * Mathf.Pow(Time.deltaTime, 2) / 2;
        speed += acceleration * Time.deltaTime;
       return deltaPos;      
    }

     private void OnTriggerEnter(Collider other)
    {
        levelMaganer.Score(10);
        Destroy(gameObject);
    }


}
