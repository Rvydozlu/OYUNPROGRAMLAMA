using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    private Rigidbody2D rigid2D;
    private float horizontalInput;
    private float speed = 10f;
    private float topScore = 0.0f;
    public Text scoreText;
    

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if(horizontalInput < 0)
        {

            this.GetComponent<SpriteRenderer>().flipX = true;

        } else
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        if(rigid2D.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }

        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();
    }


    void FixedUpdate()
    {
        {

            horizontalInput = Input.GetAxis("Horizontal");
            rigid2D.velocity = new Vector2(horizontalInput * speed, rigid2D.velocity.y);

        }
    }
}
