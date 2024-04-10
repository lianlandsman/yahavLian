using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGravityPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cat")
        {
            if (FindObjectOfType<Cat>().upsideDown == -1)
            {
                Invoke("Land", 0.2f);
            }
            FindObjectOfType<Cat>().upsideDown = -FindObjectOfType<Cat>().upsideDown;
            //gravity = -gravity
            other.gameObject.GetComponent<Rigidbody2D>().gravityScale = -(other.gameObject.GetComponent<Rigidbody2D>().gravityScale);
        }
    }
    void Land()
    {
        FindObjectOfType<Cat>().GetComponent<Animator>().Play("normalLand");
    }
}
