using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathGround : MonoBehaviour
{
    GameObject ll;
    // Start is called before the first frame update
    void Start()
    {
        ll = GameObject.FindGameObjectWithTag("LL");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Cat" || other.collider.tag == "Girl")
        ll.GetComponent<LevelLoader>().Restart();
    }
}
