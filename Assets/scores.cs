
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class scores : MonoBehaviour
{

   // private createHole cH;
    public TextMeshProUGUI highScoreUI;
    public TextMeshProUGUI currentScoreUI;
   
    
    // Start is called before the first frame update
    void Start()
    {
       
        
       
    }

    // Update is called once per frame
    void Update()
    {
       
        currentScoreUI.text = createHole.currentScore.ToString();
        highScoreUI.text = createHole.highScore.ToString();
    }
}
