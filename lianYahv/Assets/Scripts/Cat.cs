using Newtonsoft.Json.Bson;
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
    public bool onGround = true;
    public float lookDir = 1;
    public bool stun = false;//from snake hit
    float hitCD = 4;
    float lastHit = 0;
    float hitTime = 15f/14f;
    float currentSpeed;
    public Animator animator;
    Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        controls.Cat_Controls.Enable();
        currentSpeed = speed;
        lastHit = -hitCD;
        col = GetComponent<Collider2D>();
        NormalCol();
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
            transform.Translate(currentSpeed * Time.deltaTime * direction, 0, 0);
        }
        GetComponent<Transform>().localScale = new Vector3(lookDir,1,1);
        animator.SetBool("onGround", onGround);
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
            animator.Play("Jump");
            onGround = false;
        }
    }
    public void OnHit(InputAction.CallbackContext context)
    {
        if (lastHit + hitCD <= Time.timeSinceLevelLoad)
        {
            if (context.performed && onGround && animator.GetBool("sitting") == false)
            {
                animator.Play("catHit");
                currentSpeed = 0;
                Invoke("fixSpeed", hitTime);
                lastHit = Time.timeSinceLevelLoad;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")//land
        {
            onGround = true;
            stun = false;
            animator.SetBool("scared", false);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Collider2D>().tag == "Head")
        {
            Invoke("SittingCol", 0.5f);
            animator.Play("headLand");
            animator.SetBool("sitting", true);
            onGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")//air
        {
            onGround = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<Collider2D>().tag == "Head")
        {
            Invoke("NormalCol", 0.45f);
            animator.SetBool("sitting", false);
            onGround = false;
        }
    }
    public void NormalCol()
    {
            col.offset = new Vector2(0.0511961f, -0.2648661f);
            col.GetComponent<BoxCollider2D>().size = new Vector2(1.369062f, 0.8122643f);
    }
    public void SittingCol()
    {
        col.offset = new Vector2(0.1427231f, 0.005359769f);
        col.GetComponent<BoxCollider2D>().size = new Vector2(0.6106796f, 1.352716f); 
    }
    private void fixSpeed()
    {
        currentSpeed = speed;
    }

}

