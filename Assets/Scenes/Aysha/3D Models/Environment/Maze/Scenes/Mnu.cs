using UnityEngine;

public class Mnu : MonoBehaviour
{
    public GameObject imageScreen;
    public GameObject rawImageScreen;
    public GameObject gamePanel;
    public GameObject howToPlayPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GoTorawImageScreen()
    {
        howToPlayPanel.SetActive(false);
        gamePanel.SetActive(false);
        imageScreen.SetActive(false);
        rawImageScreen.SetActive(true);
    }
}