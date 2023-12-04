using UnityEngine;
using TMPro;

public class DoorSlider : MonoBehaviour
{
    public Transform door;
    public Vector3 openPosition;
    public float slideSpeed = 5.0f;
    public TMP_Text interactionText;

    private bool isDoorMoving = false;

    void Update()
    {
        if (isDoorMoving)
        {
            MoveDoor();
        }
        // Lägg till kod för att kontrollera musknapptryckningar här om nödvändigt
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
        isDoorMoving = true;
        door.GetComponent<Collider>().enabled = false;
    }
}