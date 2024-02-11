using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cat : MonoBehaviour, Controls.ICat_ControlsActions
{
    Controls controls;
    float direction = 0;
    // Start is called before the first frame update
    void Start()
    {
        controls=new Controls();
    }
    private void Awake()
    {
        
    }
    public float JumpCat =4;

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GetComponent<Rigidbody>().velocity = new Vector2(0, JumpCat);
        }

    }
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
            transform.Translate(speed*Time.deltaTime*direction, 0, 0);     
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            direction=context.ReadValue<float>();
        }
    }
}

