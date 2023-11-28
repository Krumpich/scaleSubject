

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class createHole : MonoBehaviour
{
    public GameObject hole;
    public int num;
    Renderer rend;
    private int i = 1;
    private float alpha = 255;
    private float size = 1;
    public float targetSize;
    public GameObject bar;
    private float barSizeXConst;
    private float barSizeX;
    private float barSpeed = 1.05f; //1000
   // public GameObject timeBar;
    public GameObject player;
    public static int highScore;
    public static int currentScore;
    public GameObject playerObject;
    public GameObject highScoreUI;
    public GameObject currentScoreUI;
    public GameObject scoreSound;



    // Start is called before the first frame update
    void Start()
    {
        // num = UnityEngine.Random.Range(1,16);

        rend = hole.GetComponent<Renderer>();
        barSizeXConst = bar.transform.localScale.x;
        currentScore = 0;


    }

    // Update is called once per frame
    void Update()
    {




        if (i == 1) //hole appeareance
        {

           
            num = UnityEngine.Random.Range(1, 15);
            player.SetActive(true);
           // player.transform.localScale = new Vector2(1, 1);
          //  player.transform.position = new Vector2(0,0);
            alpha = 255;
            size = 1;
            barSizeX = barSizeXConst;
            transform.localScale = new Vector2(size, size);
            rend.material.color = new Color(176, 176, 176, alpha);
            barSpeed -= barSpeed * 0.025f;


            if (num == 1)
            {
                hole.transform.position = new Vector2(0, 0);
                hole.transform.localScale = new Vector2(3, 3);
            }
            else if (num == 2)
            {
                hole.transform.position = new Vector2(0.5f, 0);
                hole.transform.localScale = new Vector2(2, 1);
            }
            else if (num == 3)
            {
                hole.transform.position = new Vector2(-0.5f, 0);
                hole.transform.localScale = new Vector2(2, 1);
            }
            else if (num == 4)
            {
                hole.transform.position = new Vector2(0, 0);
                hole.transform.localScale = new Vector2(3, 1);
            }
            else if (num == 5)
            {
                hole.transform.position = new Vector2(0, 0.5f);
                hole.transform.localScale = new Vector2(1, 2);
            }
            else if (num == 6)
            {
                hole.transform.position = new Vector2(0, -0.5f);
                hole.transform.localScale = new Vector2(1, 2);
            }
            else if (num == 7)
            {
                hole.transform.position = new Vector2(0, 0);
                hole.transform.localScale = new Vector2(1, 3);
            }
            else if (num == 8)
            {
                hole.transform.position = new Vector2(0.5f, 0.5f);
                hole.transform.localScale = new Vector2(2, 2);
            }
            else if (num == 9)
            {
                hole.transform.position = new Vector2(-0.5f, -0.5f);
                hole.transform.localScale = new Vector2(2, 2);
            }
            else if (num == 10)
            {
                hole.transform.position = new Vector2(-0.5f, 0.5f);
                hole.transform.localScale = new Vector2(2, 2);
            }
            else if (num == 11)
            {
                hole.transform.position = new Vector2(0.5f, -0.5f);
                hole.transform.localScale = new Vector2(2, 2);
            }
            else if (num == 12)
            {
                hole.transform.position = new Vector2(0, 0.5f);
                hole.transform.localScale = new Vector2(3, 2);
            }
            else if (num == 13)
            {
                hole.transform.position = new Vector2(0, -0.5f);
                hole.transform.localScale = new Vector2(3, 2);
            }
            else if (num == 14)
            {
                hole.transform.position = new Vector2(0.5f, 0);
                hole.transform.localScale = new Vector2(2, 3);
            }
            else if (num == 15)
            {
                hole.transform.position = new Vector2(-0.5f, 0);
                hole.transform.localScale = new Vector2(2, 3);
            }


            i += 1;
        }
        else if (i == 2) //countdown
        {

            bar.transform.localScale = new Vector2(barSizeX -= barSizeXConst / barSpeed * Time.deltaTime, bar.transform.localScale.y);

            if (barSizeX <= 0)
            {
                if (hole.transform.localScale == player.transform.localScale & hole.transform.position == player.transform.position) // score a point
                {

                    scoreSound.GetComponent<AudioSource>().Play();
                    currentScore += 1;


                    if (currentScore > highScore)
                    {
                        highScore = currentScore;

                        // currentScoreUI.GetComponent<Text>().text = currentScore.ToString();
                        //  highScoreUI.GetComponent<Text>().text = highScore.ToString();
                    }

                    //  currentScoreUI.GetComponent<Text>().text = currentScore.ToString();
                }
                else // die
                {
                    SceneManager.LoadScene("dead");
                    barSpeed = 3;

                }

                player.SetActive(false);
                i += 1;
              
            }

        }
        else if (i == 3) //hole dissenegratation
        {
          
            alpha -= alpha / 0.05f * Time.deltaTime;
            rend.material.color = new Color(176, 176, 176, alpha);
            transform.localScale = new Vector2(size += targetSize / 0.2f * Time.deltaTime, size += targetSize / 0.2f * Time.deltaTime);



            if (transform.localScale.x >= 100 & alpha <= 1)
            {

                
                i = 1;

            }

        }









        
      
    }
}

