using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource musicSource;
    private bool isPlayerNear = false;

    private void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Player"))
        {
            isPlayerNear = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
        }
    }


    private void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E)) 
        {
            if (musicSource.isPlaying)
            {
                musicSource.Stop();
            }

            else
            {
                musicSource.Play();
            }

        }
        
    }
}
