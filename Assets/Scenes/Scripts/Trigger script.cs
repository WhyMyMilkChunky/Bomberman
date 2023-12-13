using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.XR;
using UnityEngine.PlayerLoop;

public class SpeedBoost : MonoBehaviour
{
  // public static int[] automaticArray = { 1, 2, 3, 4 };
  // public GameObject[] Burgs = new GameObject[automaticArray.Length];

    public TMP_Text scoreText;
    public TMP_Text timeText;
    public static float timelimit;
    public float setTimeLimit;
    public TMP_Text lifeText;
    public Player player;
    static public bool win = false;
    public int playerScore = 0;
    static public int totscore;
    static public int savscore;
    public int lives = 3;
    public AudioSource source;
    public AudioClip clip;
    public AudioClip clip2;
    public AudioClip clip3;
    // Start is called before the first frame update
    void Start()
    {   savscore = 0;
        timelimit = setTimeLimit;
        player = GetComponent<Player>();
        //playerScore = savscore;
      
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "WetFloor")
        {
            player.speed = 12.6f;
        }
        if (collision.gameObject.tag == "Burgur")
        {
            playerScore += 1;
            Debug.Log("Score:"+ playerScore);
            source.PlayOneShot(clip2);
            Object.Destroy(collision.gameObject);
         
        }
        if (collision.gameObject.tag == "SALAD")
        {  lives -= 1;
            Debug.Log("Lives:" + lives);
            source.PlayOneShot(clip);
            Object.Destroy(collision.gameObject);
            
        }
        if (collision.gameObject.tag == "finish")
        {
            win = true;
            savscore = playerScore;
            source.PlayOneShot(clip3);
            SceneManager.LoadScene(2);

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
        lifeText.SetText("Score: " + GetComponent<SpeedBoost>().lives);
        lifeText.SetText("Lives: " + lives);
        if (lives <= 0)
        {   savscore = playerScore;
            source.PlayOneShot(clip3);
            SceneManager.LoadScene(2);
            
        }
        timelimit -= Time.deltaTime;
        timeText.SetText("Time: " + Mathf.Round(SpeedBoost.timelimit));


    }
}   
