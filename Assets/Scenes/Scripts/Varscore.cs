using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Var : MonoBehaviour
{
    public int score = 0;

    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: " + score);

    }
}