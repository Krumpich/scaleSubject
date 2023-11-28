


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showUI : MonoBehaviour
{
    public GameObject ui;
    private GameObject soundObject;
    public TextMeshProUGUI muteBttn;
    private GameObject ddol;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (GameObject.Find("music(Clone)").GetComponent<AudioSource>().mute == true)
        {
            muteBttn.text = "UNMUTE MUSIC";
        }
        else
        {
            muteBttn.text = "MUTE MUSIC";
        }
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

    public void muteMusic()
    {

        soundObject = GameObject.Find("music(Clone)");

        if (soundObject.GetComponent<AudioSource>().mute == true)
        {
            soundObject.GetComponent<AudioSource>().mute = false;
            muteBttn.text = "MUTE MUSIC";
        }
        else
        {
            soundObject.GetComponent<AudioSource>().mute = true;
            muteBttn.text = "UNMUTE MUSIC";
        }

    }

}
