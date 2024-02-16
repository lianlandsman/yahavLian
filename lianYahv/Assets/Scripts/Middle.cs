using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour
{
    GameObject g1;
    GameObject g2;
    // Start is called before the first frame update
    void Start()
    {
        g1 = GameObject.FindGameObjectWithTag("Girl");
        g2 = GameObject.FindGameObjectWithTag("Cat");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3((g1.transform.position.x + g2.transform.position.x)/2, (g1.transform.position.y + g2.transform.position.y) / 2, 0);
    }
}
