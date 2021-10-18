using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformDetect : MonoBehaviour
{
    private PlayerJump pg;

    void Start()
    {
        pg = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerJump>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plataform")
        {
            FindObjectOfType<AudioManager>().Play("Land");
            pg.canJump = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plataform")
        {
            FindObjectOfType<AudioManager>().Play("Jump");
            pg.canJump = false;
        }
    }
}
