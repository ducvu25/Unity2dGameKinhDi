using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    Animator animator;
    Rigidbody2D rb;
    Vector2 delta_x;
    // Start is called before the first frame update
    void Start()
    {
        //facingRight = true;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInPut();
        UpdateAnimation();
    }
    void CheckInPut()
    {
        delta_x = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
            delta_x = Vector2.left;
        else if(Input.GetKey(KeyCode.D))
            delta_x = Vector2.right;

    }
    void UpdateAnimation()
    {
        rb.velocity = delta_x * speed;
            if(delta_x != Vector2.zero)
            {
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x)*delta_x.x, transform.localScale.y, transform.localScale.z);
                animator.SetInteger("HanhDong", 1);
            }
            else
            {
                animator.SetInteger("HanhDong", 0);
            }
    }
}
