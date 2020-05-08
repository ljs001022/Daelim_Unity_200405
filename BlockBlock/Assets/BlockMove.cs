using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    Rigidbody2D rb2d;
    bool isMoveRight;
    GameObject GM;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0;
        isMoveRight = true;
        GM = GameObject.Find("GameManager");
    }

    void Update()
    {
        if (GM.GetComponent<GameManager>().isTouch == true)
        {
            rb2d.gravityScale = 1;
            GM.GetComponent<GameManager>().isTouch = false;
            enabled = false;
        }
        if (transform.position.x < -3)
            isMoveRight = true;
        else if (transform.position.x > 3)
            isMoveRight = false;

        if (isMoveRight == true)
            transform.Translate(Vector2.right * 5 * Time.deltaTime);
        else
            transform.Translate(Vector2.right * -5 * Time.deltaTime);
    }
}