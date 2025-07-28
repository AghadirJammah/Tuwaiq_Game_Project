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
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StartPanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}