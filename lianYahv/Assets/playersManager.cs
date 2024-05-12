using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playersManager : MonoBehaviour
{
    private PlayerInputManager playerInput;
    [SerializeField] GameObject Girl;
    [SerializeField] GameObject Cat;
    bool cat = false;
    bool girl = false;
    bool done = false;
    int i = 0;
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<PlayerInputManager>().joinBehavior = PlayerJoinBehavior.JoinPlayersWhenButtonIsPressed;
        playerInput = GetComponent<PlayerInputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (done == false)
        //{
        //    Debug.Log(InputSystem.devices[i].name);
        //    Debug.Log(i);
        //    if (InputSystem.devices[i].name == "DualSense Wireless Controller" || InputSystem.devices[i].name == "DualSenseGamepadHID" && cat == false)//Girl
        //    {
        //        playerInput.playerPrefab = Girl;
        //        playerInput.JoinPlayer(i, -1, null, InputSystem.devices[i]);
        //        cat = true;
        //    }
        //    if (InputSystem.devices[i].name == "Nintendo Wireless Gamepad" || InputSystem.devices[i].name == "Nintendo Wireless Gamepad2" && girl == false)//Cat
        //    {
        //        playerInput.playerPrefab = Cat;
        //        playerInput.JoinPlayer(i, -1, null, InputSystem.devices[i]);
        //        girl = true;
        //    }
        //    if (cat && girl)
        //    {
        //        done = true;
        //        FindObjectOfType<LevelLoader>().findPlayers();
        //    }
        //    i++;

        //}
    }
    private void OnEnable()
    {
        playerInput.onPlayerJoined += AddPlayer;
    }

    private void OnDisable()
    {
        playerInput.onPlayerJoined -= AddPlayer;
    }
    public void AddPlayer(PlayerInput player)
    {
        Debug.Log("join");
        playerInput.playerPrefab = Girl;
    }
}
