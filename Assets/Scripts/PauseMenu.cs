using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool ispaused = false;

    public GameObject pausemenuUI;
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                Resume();
            }
            else Pause();
        }
		
	}

    public void Resume()
    {
        ispaused = false;
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        ispaused = true;
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ReturnToMainMenu()
    {
        pausemenuUI.SetActive(false);
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }

}
