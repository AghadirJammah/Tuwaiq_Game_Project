using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject imageScreen;
    public GameObject StartPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    
    
    public void GoToStartPanel()
    {
        StartPanel.SetActive(true);
        imageScreen.SetActive(false);
    }
public void onExitButtonPreesed()
    {
        Application.Quit();
    }
}
