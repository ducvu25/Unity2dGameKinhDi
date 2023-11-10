using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    //[SerializeField] GameObject den_pin;
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
        //Debug.Log(SettingController.item[0]);
        delta_x = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
            delta_x = Vector2.left;
        else if(Input.GetKey(KeyCode.D))
            delta_x = Vector2.right;
        else if (Input.GetKeyDown(KeyCode.S) && SettingController.item[0] == 1){
            if(animator.GetInteger("HanhDong") == 2)
                animator.SetInteger("HanhDong", 0);
            else
                animator.SetInteger("HanhDong", 2);
        }

    }
    void UpdateAnimation()
    {
        rb.velocity = delta_x * speed;
            if(delta_x != Vector2.zero)
            {
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x)*delta_x.x, transform.localScale.y, transform.localScale.z);
                animator.SetInteger("HanhDong", 1);
                AdioController.instance.Play(0);
            }
            else
            {
            AdioController.instance.Stop(0);
                if (animator.GetInteger("HanhDong") != 2)
                {
                    animator.SetInteger("HanhDong", 0);
                }
            }
    }
}
