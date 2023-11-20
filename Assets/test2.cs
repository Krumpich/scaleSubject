using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{

    Renderer renderer;
    private int i = 1;
    private float alpha = 255;
    private float size = 1;
    public float targetSize;
    public GameObject bar;
    private float barSizeXConst;
    private float barSizeX;
    private float barSpeed = 1000;
    public GameObject timeBar;
    public GameObject player;
    public int highScore;
    public int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(wait());
        renderer = GetComponent<Renderer>();
        barSizeXConst = bar.transform.localScale.x;
}

    // Update is called once per frame
    void Update()
    {

        if (i == 1)
        {
            
            alpha = 255;
            size = 1;
            barSizeX = barSizeXConst;
            transform.localScale = new Vector2(size, size);
            renderer.material.color = new Color(255, 255, 255, alpha);
            barSpeed -= barSpeed/100;
            i += 1;
        }
        else if (i == 2)
        {

            bar.transform.localScale = new Vector2(barSizeX -= barSizeXConst / barSpeed, bar.transform.localScale.y);

            if (barSizeX <= 0)
            {
                if(transform.localScale == player.transform.localScale & transform.position == player.transform.position)
                {
                    currentScore += 1;
                }
                else
                {
                    if(currentScore > highScore) 
                    {
                        highScore = currentScore;
                    }
                }


                i += 1;
            }

        }
        else if(i == 3)
        {
           alpha -= alpha / 20;
           renderer.material.color = new Color(255, 255, 255, alpha);
           transform.localScale = new Vector2(size += targetSize/100, size += targetSize / 100);
          
           

            if (transform.localScale.x >= 100 & alpha <= 1)
            {
                
                i = 1;
            }

        }

        
       
    }

    IEnumerator wait()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(5);
        Debug.Log("End");
        StartCoroutine(wait());
    }
}
