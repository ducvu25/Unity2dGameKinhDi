using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Transform[] listPoint;
    int next;
    Rigidbody2D rb;
    Vector2 delta_x;
    bool facingRight;
    float time_random;
    float time_idle;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        next = 0;
        facingRight = false;
        time_random = Random.Range(1, 3);
        time_idle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (time_random > 0)
        {
            if (facingRight)
            {
                delta_x = Vector2.right;
                if (transform.position.x > listPoint[next].position.x)
                {
                    next = (next + 1) % listPoint.Length;
                    Debug.Log(next);
                    if (transform.position.x > listPoint[next].position.x)
                    {
                        facingRight = !facingRight;
                        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * delta_x.x, transform.localScale.y, transform.localScale.z);
                    }
                }
            }
            else
            {
                delta_x = Vector2.left;
                if (transform.position.x < listPoint[next].position.x)
                {
                    next = (next + 1) % listPoint.Length;
                    if (transform.position.x < listPoint[next].position.x)
                    {
                        facingRight = !facingRight;
                        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * delta_x.x, transform.localScale.y, transform.localScale.z);
                    }
                }
            }
            rb.velocity = delta_x * speed;
            time_random -= Time.deltaTime;
        }
        else
        {
            if(time_idle > 0)
            {
                time_idle -= Time.deltaTime;
            }
            else
            {
                time_random = Random.Range(1, 3);
                time_idle = Random.Range(1, 2);
            }

        }
    }
}
