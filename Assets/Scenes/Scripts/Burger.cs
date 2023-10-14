using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger : MonoBehaviour
{
    Var playerScore;
    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Var>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerScore.score += 1 ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
