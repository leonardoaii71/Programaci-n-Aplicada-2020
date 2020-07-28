using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMaganer : MonoBehaviour
{
    public TextMesh ScoreValueText;
    public GameObject[] flyers;
    public int ScoreValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn(){
        StartCoroutine("waitRandomSeconds");
    }
    IEnumerator waitRandomSeconds() 
    {
        int randomSecnd = Random.Range(1, 4);
        yield return new WaitForSeconds(randomSecnd);
        Instantiate(flyers[Random.Range(0, flyers.Length)], new Vector3(0, 3, 0), Quaternion.identity);
        Spawn(); //loop para repetir disparo una y otra vez.
    }

    public void Score(int value){
        this.ScoreValue += value;
        ScoreValueText.text = ScoreValue.ToString();
    }
}
