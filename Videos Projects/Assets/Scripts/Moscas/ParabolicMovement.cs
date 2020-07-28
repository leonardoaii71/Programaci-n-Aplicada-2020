using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicMovement : MonoBehaviour
{
    Vector3 startingSpeed;
    Vector3 currentSpeed;

    private Vector3 deltaPos;
    const float speed = 10f;
    const float MIN_Y = -4.6f, MAX_Y = 4.6f, MIN_X = -2.4f, MAX_X = 2.4f;
    float[] angles = {2.14f, 0.785398f, 2.0944f, 4.79966f};
    LevelMaganer levelMaganer;
    float shootingAngle;

    // Start is called before the first frame update
    private void Start() {
        startingSpeed = new Vector3(3f, 3f);
        shootingAngle = angles[Random.Range(0, angles.Length)];
        currentSpeed = new Vector3(startingSpeed.x * Mathf.Cos(shootingAngle), startingSpeed.y * Mathf.Sin(shootingAngle));
    }

    private void Awake() {
       levelMaganer = GameObject.Find("LevelManager").GetComponent<LevelMaganer>();
    }
    // Update is called once per frame
    void Update()
    {
        //shootingAngle = Mathf.PingPong(Time.time, 180);
        //currentSpeed = new Vector3(currentSpeed.x * Mathf.Cos(Mathf.Deg2Rad * shootingAngle), currentSpeed.y * Mathf.Sin(Mathf.Deg2Rad * shootingAngle));

        deltaPos = currentSpeed * Time.deltaTime + Physics.gravity * Mathf.Pow(Time.deltaTime, 2) / 2;
        gameObject.transform.Translate(deltaPos);
        currentSpeed += Physics.gravity * Time.deltaTime;

        transform.position = new Vector3(
           Mathf.Clamp(transform.position.x, MIN_X, MAX_X),
           Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y)
       );
    }

    public void Shoot(Vector3 startingSpeed, float shootingAngle)
    {
        currentSpeed = new Vector3(startingSpeed.x * Mathf.Cos(shootingAngle), startingSpeed.y * Mathf.Sin(shootingAngle));

    }

    private void OnTriggerEnter(Collider other)
    {
        levelMaganer.Score(10);
        Destroy(gameObject);
    }

}
