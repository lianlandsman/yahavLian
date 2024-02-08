using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.InputSystem;

public class Girl_Movement : MonoBehaviour, Controls.IGirl_ControlsActions
{
    Controls controls;
    // Start is called before the first frame update
    private void Awake()
    {
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
        
    }
    void Controls.IGirl_ControlsActions.OnHorizontal(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
        else
        {

        }
    }

    void Controls.IGirl_ControlsActions.OnJump(InputAction.CallbackContext context)
    {
        return;
    }
}
