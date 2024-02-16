using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float speed = 4;
    public GameObject platform;
    public float hightLim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "Cat" || other.collider.tag == "Girl")
        {
            if (platform.transform.position.y <= hightLim)
            {
                platform.transform.Translate(0, speed * Time.deltaTime, 0);

            }
        }
    }
   
 }
