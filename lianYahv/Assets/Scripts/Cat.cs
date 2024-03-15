using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cat : MonoBehaviour, Controls.ICat_ControlsActions
{
    Controls controls;
    float direction = 0;
    public float speed = 10;
    public float JumpCat = 4;
    bool onGround = true;
    float lookDir = 1;
    public bool stun = false;//from snake hit
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
        controls.Cat_Controls.Enable();
    }
    private void OnDestroy()
    {
        controls.Cat_Controls.Disable();
    }
    private void Awake()
    {
        animator = GetComponent<Animator>();
        controls = new Controls();
        controls.Cat_Controls.SetCallbacks(this);
    }


  
    // Update is called once per frame
    void Update()
    {
        if (stun == false)
        {
            transform.Translate(speed * Time.deltaTime * direction, 0, 0);
        }
        GetComponent<Transform>().localScale = new Vector3(lookDir,1,1);
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            direction = context.ReadValue<float>();
            lookDir = context.ReadValue<float>();
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
            direction = 0;
        }
    }
    
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && onGround)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,JumpCat);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")//land
        {
            onGround = true;
            stun = false;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")//air
        {
            onGround = false;
        }
    }
}

