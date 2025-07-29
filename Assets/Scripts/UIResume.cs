using UnityEngine;

public class UIResume : MonoBehaviour
{
    public GameObject PausePanel;
    public bool isPaused = false;



    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {

            if (isPaused)
            {
                PausePanel.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                PausePanel.SetActive(true);
                Time.timeScale = 0;
            }
            isPaused = !isPaused;
        }
    }
}

    
