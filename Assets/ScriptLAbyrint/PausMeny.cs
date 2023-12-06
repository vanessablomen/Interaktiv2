using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; 


    private void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed");

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
        pauseMenuUI.SetActive(false); // D�ljer pausmenyn
        Time.timeScale = 1; // �terupptar spelet
    }

    // Funktion f�r att avsluta spelet
    public void QuitGame()
    {
        Debug.Log("Avslutar spelet");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}