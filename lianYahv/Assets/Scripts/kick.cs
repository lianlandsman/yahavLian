using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick : MonoBehaviour
{
    // Start is called before the first frame update
    float kickHeight = 4;
    float kickSpeed = 6;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snake")
        {
            
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(kickSpeed * FindObjectOfType<Girl>().lookDir, kickHeight);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Snake")
        {
            Debug.Log("d");
        }
    }
}
