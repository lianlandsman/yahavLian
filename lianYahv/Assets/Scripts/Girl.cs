using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.InputSystem;

public class Girl : MonoBehaviour, Controls.IGirl_ControlsActions
{
    Animator animator;
    float direction = 0;
    float lookDir = 1;
    public float speed = 10;
    Controls controls;
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
    }
    private void OnDestroy()
    {
        controls.Girl_Controls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * direction, 0, 0);
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
}
