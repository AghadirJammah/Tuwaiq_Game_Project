using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{


    public GameObject winScreen;   // ���� �����
    public GameObject player;      // ������
    public GameObject restartButton;  // �� ����� �����
    public GameObject mainMenuButton; // �� ������ ��� ������ ��������

    void Start()
    {
        // ����� ���� ����� ��� ����� ������
        winScreen.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)  // ���� ��� ��� ������ �� ���� ��� ������
        {
            // ����� ���� ����� ��� �����
            Time.timeScale = 0;  // ����� ������
            winScreen.SetActive(true);  // ����� ���� �����
        }
    }

    // ����� ����� ������
    public void RestartGame()
    {
        Time.timeScale = 1; // ������� ������
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // ����� ����� ������ ������
    }

    // ������ ��� ������ ��������
    public void GoToMainMenu()
    {
        Time.timeScale = 1; // ������� ������
        SceneManager.LoadScene("MainMenu");  // �� ������ ��� ������ ��� ������ �������
    }
}


