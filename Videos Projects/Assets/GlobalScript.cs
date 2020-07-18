using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    public ScoreManager ScoreManager;
    // Start is called before the first frame update
    private void Awake() {
        ScoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ScoreManager.IncrementScore();
        }
    }
}
