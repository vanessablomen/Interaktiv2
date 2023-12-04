
using System;
using Unity.VisualScripting;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int winningScore = 6;

    public bool doorOpen = true;
    public void HandleWin()
    {
        if(doorOpen)
        {
            
            Destroy(gameObject);

            doorOpen = false;
        }
    }
}





