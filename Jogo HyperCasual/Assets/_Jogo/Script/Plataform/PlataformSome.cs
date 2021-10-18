using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformSome : MonoBehaviour
{
    private Rigidbody2D PlataformSRB;

    void Start()
    {
        PlataformSRB = gameObject.GetComponent<Rigidbody2D>();

    }
    IEnumerator PlataformaSome()
    {
        yield return new WaitForSeconds(5);
        PlataformHorizontalSome();
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(PlataformaSome());
        }
    }

    void PlataformHorizontalSome()
    {
        gameObject.SetActive(false);
    }
}
