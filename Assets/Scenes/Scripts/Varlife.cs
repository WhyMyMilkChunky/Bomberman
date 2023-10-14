using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Varlife : MonoBehaviour
{

    public int lives = 3;
    public TMP_Text lifeText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        lifeText.SetText("Lives: " + lives);
    }
}
