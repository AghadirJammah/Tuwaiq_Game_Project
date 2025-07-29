using Unity.VisualScripting;
using UnityEngine;

public class Starts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public GameObject StartPanel;
    public GameObject PausePanel;
    public bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StartPanel.SetActive(false);
            Time.timeScale = 1f;
        }
        Pause();


    }
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


} //Aa