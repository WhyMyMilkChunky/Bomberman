using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        player.speed = 12.6f;
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
