using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public float snakeSpeed = 3.5f;
    public float jumpScareSpeed = 7;
    public float jumpScareHeight = 5.5f;
    public float kickX = 6;
    public float kickY = 4;
    public bool canMove = true;
    public float snakeStun = 2f;
    Transform snakeTs;

    // Start is called before the first frame update
    void Start()
    {
        snakeTs = gameObject.transform;
        GameObject girl = GameObject.FindGameObjectWithTag("Girl");
        Physics2D.IgnoreCollision(girl.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            transform.Translate(snakeSpeed * Time.deltaTime, 0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //אם חיובי ביחס לציר האיקס
        if (gameObject.GetComponent<Transform>().localScale.x > 0)
        {
            jumpScareSpeed = System.Math.Abs(jumpScareSpeed);
        }
        else//אם שלילי
        {
            jumpScareSpeed = -System.Math.Abs(jumpScareSpeed);
        }
        if (other.tag == "Cat")
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(jumpScareSpeed,jumpScareHeight);
            FindObjectOfType<Cat>().stun = true;
            FindObjectOfType<Cat>().onGround = false;
            other.GetComponent<Animator>().Play("catScared");
            other.GetComponent<Animator>().SetBool("scared", true);
        }

        if (other.tag == "SnakeReverse")
        {
            snakeSpeed = -snakeSpeed;
            GetComponent<Transform>().localScale = new Vector3(-snakeTs.localScale.x, snakeTs.localScale.y, snakeTs.localScale.z);
        }

        if (other.tag == "Kick")
        {
            canMove = false;
            GetComponentInParent<Animator>().speed = 0;
            Invoke("SnakeStun", snakeStun);
            GetComponent<Rigidbody2D>().velocity = new Vector2(kickX * FindObjectOfType<Girl>().lookDir, kickY);
        }
    }
    void SnakeStun()
    {
        GetComponentInParent<Animator>().speed = 1;
        GetComponent<Animator>().speed = 1;
        canMove = true;
    }
}
