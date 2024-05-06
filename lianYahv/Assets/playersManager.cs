using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playersManager : MonoBehaviour
{
    private PlayerInputManager playerInput;

    [SerializeField] GameObject Girl;
    [SerializeField] GameObject TG;

    // Start is called before the first frame update
    void Awake()
    {
        playerInput = GetComponent<PlayerInputManager>();
    }

    private void OnEnable()
    {
        playerInput.onPlayerJoined += AddPlayer;
    }

    private void OnDisable()
    {
        playerInput.onPlayerJoined -= AddPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPlayer(PlayerInput player)
    {
        Debug.Log("join");
        TG.GetComponent<CinemachineTargetGroup>().AddMember(player.gameObject.transform, 1, 2.5f);
        playerInput.playerPrefab = Girl;
    }

}
