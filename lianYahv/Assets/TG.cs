using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TG : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject girl = GameObject.FindGameObjectWithTag("Girl");
        GameObject cat = GameObject.FindGameObjectWithTag("Cat");
        GetComponent<CinemachineTargetGroup>().AddMember(cat.transform, 1, 2.5f);
        GetComponent<CinemachineTargetGroup>().AddMember(girl.transform, 1, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
