using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public ComputerInteraction computerInteraction;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {


            if (Time.timeScale == 1)
            {
                Pause();
            }
            else
            {
                Resume();
            }

        }

    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true); // Aktiverar pausmenyn
        Time.timeScale = 0; // Pausar spelet

    }

    // Funktion f�r att �teruppta spelet
    public void Resume()
    {
		Debug.Log("Resume");
		pauseMenuUI.SetActive(false); // D�ljer pausmenyn
        Time.timeScale = 1; // �terupptar spelet
	
	}

    // Funktion f�r att avsluta spelet
    public void QuitGame()
    {

		Debug.Log("QuitGame called.");
		computerInteraction.QuitAndSwitchToMainScene();
		Time.timeScale = 1; // �terupptar spelet

	}
}