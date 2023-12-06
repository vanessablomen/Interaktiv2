using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MusicController : MonoBehaviour
{
    public AudioSource musicSource;

    private bool isPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isPlaying)
            {
                musicSource.Stop();
                isPlaying = false;
            }
            else
            {
                musicSource.Play();
                isPlaying = true;
            }

        }
    }
}
