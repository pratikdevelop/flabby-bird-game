using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circl : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public logicscript logic;
    public bool birdIsAlive = true;
    public float flapStrength;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for input from both keyboard and touch screen
        if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0) && birdIsAlive)
        {
            // Handle keyboard input
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myrigidbody.velocity = Vector2.up * flapStrength;
            }
            // Handle touch input
            else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                myrigidbody.velocity = Vector2.up * flapStrength;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
