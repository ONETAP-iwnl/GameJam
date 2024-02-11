using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public Animator anim;

    [SerializeField]
    private float moveSpeed;

    public float x, y;

    private bool IsWalking;

    private Vector3 moveDir;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //public void Update()
    //{
    //    x = Input.GetAxisRaw("Horizontal");
    //    y = Input.GetAxisRaw("Vertical");

    //    if(x != 0 || y != 0)
    //    {
    //        anim.SetFloat("X", x);
    //        anim.SetFloat("Y", y);

    //        if(IsWalking)
    //        {
    //            IsWalking = true;
    //            anim.SetBool("IsMoving", IsWalking);
    //        }
    //    }
    //    else
    //    {
    //        if(!IsWalking) 
    //        {
    //            IsWalking = false;
    //            anim.SetBool("IsMoving", IsWalking);
    //            StopMoving();
    //        }
    //    }
    //}\

    public void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        // Создаем вектор направления на основе ввода
        moveDir = new Vector3(x, y).normalized;

        if (moveDir != Vector3.zero)
        {
            // Устанавливаем анимацию и флаг IsWalking, если игрок двигается
            anim.SetFloat("X", moveDir.x);
            anim.SetFloat("Y", moveDir.y);
            IsWalking = true;
            anim.SetBool("IsMoving", IsWalking);
        }
        else
        {
            // Останавливаем движение и анимацию, если игрок не двигается
            IsWalking = false;
            anim.SetBool("IsMoving", IsWalking);
            StopMoving();
        }
    }

    public void FixedUpdate()
    {
        rb.velocity = moveDir * moveSpeed * Time.deltaTime;
    }


    public void StopMoving()
    {
        rb.velocity = Vector3.zero;
    }
}
