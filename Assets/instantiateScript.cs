
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateScript : MonoBehaviour
{

    public GameObject musicObject;
    //static GameObject instantiatedObject;

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
        if (sceneChanger.played == false)
        {
            Instantiate(musicObject);
        }
        
    }
}
