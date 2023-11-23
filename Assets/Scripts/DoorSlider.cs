using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorSlider : MonoBehaviour
{
    public Transform door;
    private bool isOpen = false;
    public Vector3 closedPosition ; 
    public Vector3 openPosition;
    public float slideSpeed = 5.0f;
    public TMP_Text interactionText;
    private bool isPlayerNear = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerNear)
        {
            Debug.Log("Player is near the door");
            if( Input.GetKeyDown(KeyCode.E))

            { 
                Debug.Log("E pressed"); 
                ToggleDoor();

            }
        }
        if (isOpen)
        {
            door.position = Vector3.Lerp(door.position, openPosition, Time.deltaTime * slideSpeed);
        }
        else
        {
            door.position = Vector3.Lerp(door.position, closedPosition, Time.deltaTime * slideSpeed);
        }
        
    }

    public void ToggleDoor() 
    {
        isOpen = true;
        door.GetComponent<Collider>().enabled = false;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            interactionText.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            isPlayerNear = false;
            interactionText.gameObject.SetActive(false);    
        }
    }
}
