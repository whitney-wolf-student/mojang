using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float jumpForce = 10.0f;
    public bool isFalling = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFalling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 jumpDirection = Vector3.up * jumpForce;
                rigidbody.AddForce(jumpDirection, ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("On Collision Enter");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isFalling = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isFalling = true;
        }
    }
}
