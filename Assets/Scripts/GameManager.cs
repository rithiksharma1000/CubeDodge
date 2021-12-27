using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool endgame = false;
    public float restartdelay = 3f;
    public GameObject completelevelUI;
    public void EndGame()
    {
        if (!endgame)
        {
            endgame = true;
            Debug.Log("GAME OVER !!");
            Invoke("Restart", restartdelay);
        }
    }
	
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void nextlevel()
    {
        completelevelUI.SetActive(true);
    }
}
