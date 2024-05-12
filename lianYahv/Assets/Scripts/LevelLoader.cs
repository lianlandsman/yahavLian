using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    GameObject girl;
    GameObject cat;
    public Vector2[] GirlSP = new Vector2[7];
    public Vector2[] CatSP = new Vector2[7];
    // Start is called before the first frame update
    void Start()
    {
        GirlSP[1] = new Vector2(-9.44f, -7.518391f);
        GirlSP[2] = new Vector2(0, 0);
        GirlSP[3] = new Vector2(0, 0);
        GirlSP[4] = new Vector2(0, 0);
        GirlSP[5] = new Vector2(0, 0);
        GirlSP[6] = new Vector2(0, 0);

        CatSP[1] = new Vector2(-7.56f, -8.324122f);
        CatSP[2] = new Vector2(0, 0);
        CatSP[3] = new Vector2(0, 0);
        CatSP[4] = new Vector2(0, 0);
        CatSP[5] = new Vector2(0, 0);
        CatSP[6] = new Vector2(0, 0);

    }
    private void Awake()
    {
        girl = GameObject.FindGameObjectWithTag("Girl");
        cat = GameObject.FindGameObjectWithTag("Cat");
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            LoadNextScene();
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Invoke("TP", 0.05f);

    }
    public void Restart()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Invoke("TP", 0.05f);
    }
    public void findPlayers()
    {
        girl = GameObject.FindGameObjectWithTag("Girl");
        cat = GameObject.FindGameObjectWithTag("Cat");
    }
    public void TP()
    {
        girl.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        cat.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        girl.transform.position = GirlSP[SceneManager.GetActiveScene().buildIndex];
        cat.transform.position = CatSP[SceneManager.GetActiveScene().buildIndex];
    }
}
