using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject imageScreen;
    public GameObject rawImageScreen;
 
    public void GoToImageScreen()
    {
        rawImageScreen.SetActive(false);
        imageScreen.SetActive(true);
    }
}