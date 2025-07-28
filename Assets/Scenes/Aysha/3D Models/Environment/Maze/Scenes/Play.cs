using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject imageScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Playbottun()
    {
        Debug.Log("Hey");
        SceneManager.LoadScene("GameAysha");
    }
    public void onExitButtonPreesed()
    {
        Application.Quit();
    }
}