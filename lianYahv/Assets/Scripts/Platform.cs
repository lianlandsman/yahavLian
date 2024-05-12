using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Platform : MonoBehaviour
{
    public GameObject platform;
    public GameObject notPressed;
    public GameObject pressed;
    public float moveSpeed = 3;
    public string x = "1-up, 2-down, 3-right, 4-left";
    public int direction;
    bool moving = false;
    public bool girlOn = false;
    public bool catOn = false;
    public GameObject girl;
    public GameObject cat;
    //border
    public float lim;
    // Start is called before the first frame update
    void Start()
    {
        pressed.SetActive(false);
        girl = GameObject.FindGameObjectWithTag("Girl");
        cat = GameObject.FindGameObjectWithTag("Cat");
    }
    // Update is called once per frame
    void Update()
    {
        girlOn = girl.GetComponent<Girl>().onElevator;
        catOn = cat.GetComponent<Cat>().onElevator;
        if (moving)
        {
            if (direction == 1 && platform.transform.position.y <= lim)//up
            {
                platform.transform.Translate(0,moveSpeed * Time.deltaTime,0);
                if (girlOn) 
                { 
                    girl.transform.Translate(0, moveSpeed * Time.deltaTime, 0);
                }
                if (catOn) 
                { 
                    cat.transform.Translate(0, moveSpeed * Time.deltaTime, 0);
                }
            }
            if (direction == 2 && platform.transform.position.y >= lim)//down
            {
                platform.transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
                if (girlOn)
                {
                    girl.transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
                }
                if (catOn)
                {
                    cat.transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
                }
            }
            if (direction == 3 && platform.transform.position.x <= lim)//right
            {
                platform.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
                if (girlOn)
                {
                    girl.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
                }
                if (catOn)
                {
                    cat.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
                }
            }
            if (direction == 4 && platform.transform.position.x >= lim)//left
            {
                platform.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
                if (girlOn)
                {
                    girl.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
                }
                if (catOn)
                {
                    cat.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
                }
                
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        moving = true;
        notPressed.SetActive(false);
        pressed.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        moving = false;
        notPressed.SetActive(true);
        pressed.SetActive(false);
    }
}
