using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;

public class Spider : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    GameObject face;
    public bool scared = false;
    public GameObject gO;
    void Start()
    {
        animator = GetComponent<Animator>();
        face = GameObject.FindGameObjectWithTag("Face");
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "CatHit")
        {
                animator.Play("death");
                GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Invoke("BackToNormal", 0.95f);
                Invoke("Death", 1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Collider2D>().tag == "Girl")
        {
            if (transform.position.x - face.transform.position.x > 0)
            {
                FindObjectOfType<Girl>().x = 1;
            }
            else// < 0
            {
                FindObjectOfType<Girl>().x = -1;
            }
            face.GetComponent<SpriteRenderer>().enabled = true;
            FindObjectOfType<Girl>().scared = true;
        }
    }
        
    private void OnTriggerExit2D(Collider2D other)
    {
        face.GetComponent<SpriteRenderer>().enabled = false;
        FindObjectOfType<Girl>().scared = false;
        FindObjectOfType<Girl>().GetComponent<Animator>().speed = 1;
    }
    void Death()
    {
        Destroy(gameObject);
    }
    void BackToNormal()
    {
        FindObjectOfType<Girl>().scared = false;
        face.GetComponent<SpriteRenderer>().enabled = false;
    }
}
