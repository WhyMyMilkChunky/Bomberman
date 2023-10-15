using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class SpeedBoost : MonoBehaviour
{
    public TMP_Text scoreText;
    public Player player;
    public int playerScore = 0;
    public int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        
      
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WetFloor")
        {
            player.speed = 12.6f;
        }
        if (collision.gameObject.name == "Burgur")
        {
            playerScore += 1;
            Debug.Log("Score:"+ playerScore);
            Object.Destroy(collision.gameObject);
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(2f);

        player.speed = 6.6f;
    }
    void Update()
    {
        scoreText.SetText("Score: " + GetComponent<SpeedBoost>().playerScore);
    }
}   
