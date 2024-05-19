using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onPlat : MonoBehaviour
{
    GameObject girl;
    GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        girl = GameObject.FindGameObjectWithTag("Girl");
        cat = GameObject.FindGameObjectWithTag("Cat");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Girl")
        {
            girl.GetComponent<Girl>().onElevator = true;
            girl.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
        if (other.collider.tag == "Cat")
        {
            cat.GetComponent<Cat>().onElevator = true;
            cat.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Girl")
        {
            girl.GetComponent<Girl>().onElevator = false;
            girl.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        if(other.collider.tag == "Cat")
        {
            cat.GetComponent<Cat>().onElevator = false;
            cat.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
