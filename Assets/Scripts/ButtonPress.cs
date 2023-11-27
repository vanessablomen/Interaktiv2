using UnityEditor.SearchService;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public DoorSlider doorSlider;
	public Transform cam;
	public LayerMask lm;

    private bool isPlayerNear = false;
	RaycastHit hit;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
				if (Physics.Raycast(cam.position, cam.forward, out hit, Mathf.Infinity, lm))
				{
					doorSlider.ToggleDoor();
				}
		}
	}

}