using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public int rgb;
    public Vector2 scale;
    Renderer renderer;
    private int i = 1;
    private float alpha = 255f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        
        
    }

    // Update is called once per frame
    private void Update()
    {

        //   for (int i = 0;i < 10; i++)
        //  {

        // }

        //  transform.localScale = Vector2.Lerp(transform.localScale, scale, Time.deltaTime);
        //  lerpedColor = Color.Lerp(new Color(255,255,255), new Color(0,0,0),Time.fixedTime);
        //  renderer.material.color = lerpedColor;


       

        if (i == 1)
        {
            renderer.material.color = new Color(255,255,255);
            transform.localScale = new Vector2(1, 1);
            alpha = 255;
            i += 1;
          //  Debug.Log(i);
        }
        else if(i != 1 & i != 255)
        {
            renderer.material.color = new Color(255, 255, 255, alpha -= alpha/255);
            i += 1;
          //  Debug.Log(i);
        }
        else if (i == 255)
        {

           
            i = 1;
          //  Debug.Log(i);
        }

        

    }

   

}
