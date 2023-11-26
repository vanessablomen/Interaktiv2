using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using Unity.VisualScripting;

public class DoorSlider : MonoBehaviour
{
    public Transform door;

    public Vector3 openPosition;
    public float slideSpeed = 5.0f;
    public TMP_Text interactionText;
    private bool isPlayerNear = false;
    private bool isDoorMoving = false;
 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (isDoorMoving)
        {
            MoveDoor();
        }

    }

    private void MoveDoor()
    {
        if (door.position != openPosition)
        {
            door.position = Vector3.Lerp(door.position, openPosition, Time.deltaTime * slideSpeed);
        }
        else
        {
            isDoorMoving = false; // Stoppa dörrrörelsen när öppen position är nådd
        }
    }

    public void ToggleDoor()
    {
        if (isPlayerNear)
        {
            isDoorMoving = true;
            door.GetComponent<Collider>().enabled = false;
        }
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
