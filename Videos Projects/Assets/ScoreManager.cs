using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int currentScore = 0;
    public TextMesh Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        Scoretext.text = currentScore.ToString();
    }

    // Update is called once per frame
   public void IncrementScore(){
       currentScore++;
       Scoretext.text = currentScore.ToString();
   }
}
