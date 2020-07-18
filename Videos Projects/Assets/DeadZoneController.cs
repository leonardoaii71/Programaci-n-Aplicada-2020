using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneController : MonoBehaviour
{
    public ScoreManager ScoreManager;
    // Start is called before the first frame update
    private void Awake() {
        ScoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        //Destroy(other.gameObject);
         ScoreManager.IncrementScore();
    }
}
