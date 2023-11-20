using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showUI : MonoBehaviour
{
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show()
    {
        ui.SetActive(true);
    }

    public void hide()
    {
        ui.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
