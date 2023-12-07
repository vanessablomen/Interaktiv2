using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource musicSource;
    private bool isPlayerNear = false;
    public Transform player;
    public Transform radio;

	private void Start()
	{

	}
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
        if (Vector3.Distance(player.position, radio.position) < 2f && Input.GetKeyDown(KeyCode.E))
        {
            if (musicSource.enabled)
            {
                musicSource.enabled = false;
            }
            else
            {

                musicSource.enabled = true;
            }

            musicSource.volume = 1 - (Vector3.Distance(player.position, radio.position) / 22);


        }
    }
}
