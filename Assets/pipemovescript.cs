using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10f;

    void Update()
    {
        MovePipe();
    }

    void MovePipe()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < -32f)
        {
            Destroy(gameObject);
        }
    }
}
