
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class highScore : MonoBehaviour
{

    public TextMeshProUGUI highScoreUI;
    public TextMeshProUGUI scoreUI;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = createHole.currentScore.ToString();
        highScoreUI.text = "HIGHSCORE: " + createHole.highScore.ToString();
       
    }
}
