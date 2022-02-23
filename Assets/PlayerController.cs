using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int moveSpeed;
    int Points = 0;

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);

        if (transform.position.x <= -9)
        {
            transform.position = new Vector2(-7, -1);
        }
        else if (transform.position.x >= 9)
        {
            transform.position = new Vector2(7, -1);
        }

        if (Points >= 30)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Mangor")
        {
            Points += 1;
            Debug.Log(Points);
        }
    }
}