using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Canvas;     
    public GameObject Canvas1;    
    public GameObject Image;
    public GameObject Panel;

    public void OpenMenuFromWin()
    {
        Canvas.SetActive(false);
        Canvas1.SetActive(true);
        Image.SetActive(true);
    }
    public void GoToPanel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}

