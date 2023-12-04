using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class TextManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int hearts = 0;
    private bool hasWon = false; 
    public int winningScore = 6;
    public ExitTrigger exitTrigger; 
    public DoorController doorController;
  


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text =  hearts + "/6 ";
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasWon)
        {

            if (hearts >= winningScore)
            {
                doorController.HandleWin(); 
            }
        }
    }

    public void AddHearts()
    {
        

            hearts++;
            UpdateScoreText();
        
    }

    void UpdateScoreText()
    {
        scoreText.text = hearts + "/6 ";
    }

    void UpdateTotalScoreText()
    { 
        scoreText.text = " / " + winningScore;
    }

   
    public void PlayerWins()
    {
        if (!hasWon)
        {

            hasWon = true;
            doorController.HandleWin();
            
           
        }
    }


}
