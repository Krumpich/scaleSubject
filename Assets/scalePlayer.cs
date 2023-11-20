using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalePlayer : MonoBehaviour
{
    public GameObject square;
    public float scaleAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            square.transform.localScale = new Vector2 (square.transform.localScale.x, square.transform.localScale.y + scaleAmount);
            square.transform.position = new Vector2(square.transform.position.x, square.transform.position.y + scaleAmount/2);  
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            square.transform.localScale = new Vector2(square.transform.localScale.x, square.transform.localScale.y - scaleAmount);
            square.transform.position = new Vector2(square.transform.position.x, square.transform.position.y - scaleAmount / 2);
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            square.transform.localScale = new Vector2(square.transform.localScale.x, square.transform.localScale.y + scaleAmount);
            square.transform.position = new Vector2(square.transform.position.x, square.transform.position.y - scaleAmount / 2);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            square.transform.localScale = new Vector2(square.transform.localScale.x, square.transform.localScale.y - scaleAmount);
            square.transform.position = new Vector2(square.transform.position.x, square.transform.position.y + scaleAmount / 2);
        }






        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            square.transform.localScale = new Vector2(square.transform.localScale.x + scaleAmount, square.transform.localScale.y);
            square.transform.position = new Vector2(square.transform.position.x - scaleAmount / 2, square.transform.position.y);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            square.transform.localScale = new Vector2(square.transform.localScale.x - scaleAmount, square.transform.localScale.y);
            square.transform.position = new Vector2(square.transform.position.x + scaleAmount / 2, square.transform.position.y);
        }



        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            square.transform.localScale = new Vector2(square.transform.localScale.x + scaleAmount, square.transform.localScale.y);
            square.transform.position = new Vector2(square.transform.position.x + scaleAmount / 2, square.transform.position.y);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            square.transform.localScale = new Vector2(square.transform.localScale.x - scaleAmount, square.transform.localScale.y);
            square.transform.position = new Vector2(square.transform.position.x - scaleAmount / 2, square.transform.position.y);
        }

    }



}
