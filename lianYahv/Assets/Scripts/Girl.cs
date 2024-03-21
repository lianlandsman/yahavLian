using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Girl : MonoBehaviour, Controls.IGirl_ControlsActions
{
    Animator animator;
    float direction = 0;
    public float lookDir = 1;
    public float speed = 10;
    Controls controls;
    float kickCD = 4;
    float lastKick = 0;
    float kickTime = 21f/24f;
    float currentSpeed;
    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
        controls = new Controls();
        controls.Girl_Controls.SetCallbacks(this);
    }

    void Start()
    {
        controls.Girl_Controls.Enable();
        lastKick = -kickCD;
        currentSpeed = speed;
    }
    private void OnDestroy()
    {
        controls.Girl_Controls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(currentSpeed * Time.deltaTime * direction, 0, 0);
        GetComponent<Transform>().localScale = new Vector3(lookDir, 1, 1);
    }
    void Controls.IGirl_ControlsActions.OnHorizontal(InputAction.CallbackContext context)//movement
    {
        if (context.performed)
        {
            direction = context.ReadValue<float>();
            lookDir = context.ReadValue<float>();
            animator.SetBool("isWalking", true);
        }
        else
        {
            direction = 0;
            animator.SetBool("isWalking", false);
        }
    }
    void Controls.IGirl_ControlsActions.OnKick(InputAction.CallbackContext context)
    {
        if (lastKick + kickCD <= Time.timeSinceLevelLoad)
        {
            if (context.performed)
            {
                animator.Play("girlKick");
                currentSpeed = 0;
                Invoke("fixSpeed",kickTime);
                lastKick = Time.timeSinceLevelLoad;


            }
        }

    }
    private void fixSpeed()
    {
        currentSpeed = speed;
    }
}
