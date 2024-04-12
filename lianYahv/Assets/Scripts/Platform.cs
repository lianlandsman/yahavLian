using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject platform;
    public float moveSpeed = 3;
    public string x = "1-up, 2-down, 3-right, 4-left";
    public int direction;
    bool moving = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            if (direction == 1)//up
            {
                platform.transform.Translate(0,moveSpeed * Time.deltaTime,0);
            }
            if (direction == 2)//down
            {
                platform.transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
            }
            if (direction == 3)//right
            {
                platform.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
            }
            if (direction == 4)//left
            {
                platform.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        moving = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        moving = false;
    }
}
