using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Vector2 direct;
    public Count count;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.transform.Translate(direct.normalized * speed);
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("apple"))
        {
            Destroy(gameObject);
            count.Score += 10;

        }

        if (gameObject.CompareTag("watermelon")) {
            Destroy(gameObject);
            count.Score += 20;
        }
       
        if (gameObject.CompareTag("bomb"))
        {
            Destroy(gameObject);
            if (count.health > 0)
            {
                count.health -= 1;
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("breaker"))
        {
            if ((gameObject.CompareTag("apple")) || gameObject.CompareTag("watermelon"))
            {
                Destroy(gameObject);
                if (count.health>0)
                {
                    count.health -= 1;
                } 
            }
            if (gameObject.CompareTag("bomb"))
            {
                Destroy(gameObject);
            }
        }

    }
}