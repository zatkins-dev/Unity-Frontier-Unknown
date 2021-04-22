
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{   
    public void Start() 
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void Play()
    {
        SceneManager.LoadScene("GamesList");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

