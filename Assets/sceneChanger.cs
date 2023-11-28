
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{

    public static bool played = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void toMenu()
    {
        SceneManager.LoadScene("menu");

    }

    public void toGame()
    {
        SceneManager.LoadScene("game");
        played = true;

    }

    public void toDeathScreen()
    {
        SceneManager.LoadScene("dead");
    }



}
