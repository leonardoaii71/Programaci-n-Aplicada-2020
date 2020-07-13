using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Munition : MonoBehaviour
    {

        Vector3 currentSpeed = new Vector3();
        Vector3 deltaPos = new Vector3();
        bool shooted;

        // Update is called once per frame
        void Update()
        {
            if (!shooted)
                return;
            deltaPos = currentSpeed * Time.deltaTime + Physics.gravity * Mathf.Pow(Time.deltaTime, 2) / 2;
            gameObject.transform.Translate(deltaPos);
            currentSpeed += Physics.gravity * Time.deltaTime;
        }

        public void Shoot(Vector3 startingSpeed, float shootingAngle)
        {
            currentSpeed = new Vector3(startingSpeed.x * Mathf.Cos(shootingAngle), startingSpeed.y * Mathf.Sin(shootingAngle));
            shooted = true;
        }
    }
