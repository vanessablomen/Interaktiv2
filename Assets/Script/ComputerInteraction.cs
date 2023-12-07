using UnityEngine;

public class ComputerInteraction : MonoBehaviour
{
    public Camera mainCamera; // Referens till huvudscenens kamera
    public Camera labyrinthCamera; // Referens till labyrintspelets kamera

    public GameObject mainSceneContainer; // Huvudscenens f�r�lder-GameObject
    public GameObject labyrinthContainer; // Labyrintens f�r�lder-GameObject

    public GameObject mainCharacter;
    public GameObject labyrinthCharacter;

    public GameObject labyrinthControls; // Referens till labyrintspelets kontrollskript
    public GameObject mainControls;

    private bool isPlayerNear = false;
    private void Start()
    {
        // Avaktivera labyrintscenen vid start
        labyrinthContainer.SetActive(false);

        // Se till att huvudscenen �r aktiv
        mainSceneContainer.SetActive(true);

        // Initialiserar kameror (huvudkameran aktiv, labyrintkameran inaktiv)
        mainCamera.gameObject.SetActive(true);
        labyrinthCamera.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            ToggleLabyrinthGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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

    private void ToggleLabyrinthGame()
    {
        bool isLabyrinthActive = labyrinthContainer.activeSelf;

        // V�xla scener
        labyrinthContainer.SetActive(!isLabyrinthActive);
        mainSceneContainer.SetActive(isLabyrinthActive);

        // V�xla kameror
        labyrinthCamera.gameObject.SetActive(!isLabyrinthActive);
        mainCamera.gameObject.SetActive(isLabyrinthActive);

        // Aktivera/deaktivera karakt�rerna
        labyrinthCharacter.SetActive(!isLabyrinthActive);
        mainCharacter.SetActive(isLabyrinthActive);

        // Kontrollera om ytterligare kontrollhantering beh�vs
        if (labyrinthControls != null)
        {
            labyrinthControls.SetActive(!isLabyrinthActive);
        }

		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}



	public void Pause()
	{
		// Pause och byt kamera
		Time.timeScale = 1;

	}

	public void QuitAndSwitchToMainScene()
    {
		Debug.Log("QuitAndSwitchToMainScene called.");

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		// Avaktivera labyrintscenen och byt till huvudscenen
		labyrinthContainer.SetActive(false);
		mainSceneContainer.SetActive(true);

		labyrinthCamera.gameObject.SetActive(false);
		mainCamera.gameObject.SetActive(true);

		labyrinthCharacter.SetActive(false);
		mainCharacter.SetActive(true);

		if (labyrinthControls != null)
		{
			labyrinthControls.SetActive(false);
			Debug.Log("Labyrintkontroller avaktiverade.");
            
		}
	}



}