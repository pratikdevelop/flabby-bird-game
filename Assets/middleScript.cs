using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleScript : MonoBehaviour
{
    public logicscript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(5);
        }
    }
}
