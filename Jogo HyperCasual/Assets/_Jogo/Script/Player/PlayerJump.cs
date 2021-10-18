using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canJump = true;

    [SerializeField]
    float JumpForce;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Jump();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {
        if (canJump == true)
        {
            rb.velocity = new Vector2(0, JumpForce);
        }

    }
}
