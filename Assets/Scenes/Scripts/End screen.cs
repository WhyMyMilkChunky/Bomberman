using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;

public class Endscreen : MonoBehaviour
{
    public TMP_Text scoreText;
   
    public TMP_Text WinText;
    public TMP_Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //scoreText.SetText("Score: " + SpeedBoost.savscore + "/" + GetComponent<SpeedBoost>().totscore);
        scoreText.SetText("Score: " + SpeedBoost.savscore + " out of " + SpeedBoost.totscore);
        timeText.SetText("time left: " + Mathf.Round(SpeedBoost.timelimit));
        if (SpeedBoost.win == true)
        {
            WinText.SetText("Cangrats You Win!");
            
        }
        else
        {
            WinText.SetText("Game Over");
            
        }
    }
}
