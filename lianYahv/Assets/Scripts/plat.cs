using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plat : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Girl")
        {
            FindObjectOfType<Platform>().girlOn = true;
        }
        if (other.collider.tag == "Cat")
        {
            FindObjectOfType<Platform>().catOn = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Girl")
        {
            FindObjectOfType<Platform>().girlOn = false;
        }
        if (other.collider.tag == "Cat")
        {
            FindObjectOfType<Platform>().catOn = false;
        }

    }
}
