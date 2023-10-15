using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Varscore : MonoBehaviour
{
    SpeedBoost triggerscript;

    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        triggerscript = GetComponent<SpeedBoost>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: " + triggerscript.playerScore);

    }
}
