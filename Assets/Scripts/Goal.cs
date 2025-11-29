using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int scoreRequire;

    private Rigidbody2D player;

    public GameManager gm;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<PlayerMovement>())
            {
                return;
            }

            player = other.GetComponent<Rigidbody2D>();
            player.gravityScale = 0f;
            player.velocity = Vector2.zero;
            player.position = transform.position;

            Debug.Log("You Win!! Yeah!!");
            gm.WinGame();
        }
    }
}