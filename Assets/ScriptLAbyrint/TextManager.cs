using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class TextManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text winText;
    private int hearts = 0;
    private bool hasWon = false; 
    public int winningScore = 6; 
    public DoorController doorController;
  


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text =  hearts + "/6 ";
        UpdateScoreText();
        winText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasWon && hearts >= winningScore)
        {
            PlayerWins();

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



   
    public void PlayerWins()
    {
        if (!hasWon)
        {

            hasWon = true;
            doorController.HandleWin();
            winText.gameObject.SetActive(true);
            
           
        }
    }


}
