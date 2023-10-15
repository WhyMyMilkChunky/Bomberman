using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public Player player;
    public Varscore playerScore;
    public Varlife lives;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        playerScore = GetComponent<Varscore>();
        lives = GetComponent<Varlife>();
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

}   
