using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

 // ������� ��������
    public GameObject rawImageScreen;  // ������ ������ (����� ��� �� �������)
    public GameObject imageScreen;     // ������ ������� (����� ��� 3 �����)
    public GameObject howToPlayPanel;  // ���� ���������
    public GameObject gamePanel;       // ���� ������ ��������

    void Start()
    {
        // ������ �� �� �� ������� ����� ��� ������ ������
        rawImageScreen.SetActive(true);
        imageScreen.SetActive(false);
        howToPlayPanel.SetActive(false);
        gamePanel.SetActive(false);
    }

    // �������� �� RawImage ��� Image (������ ��������)
    public void GoToImageScreen()
    {
        rawImageScreen.SetActive(false);
        imageScreen.SetActive(true);
    }

    // �������� ��� ���� ���������
    public void ShowHowToPlay()
    {
        imageScreen.SetActive(false);
        howToPlayPanel.SetActive(true);
    }

    // ��� ������ (������ ��� Game Panel)
    public void StartGame()
    {
        imageScreen.SetActive(false);
        gamePanel.SetActive(true);
    }

    // ������ ��� ������ �������� (Image Screen)
    public void BackToMain()
    {
        howToPlayPanel.SetActive(false);
        gamePanel.SetActive(false);
        imageScreen.SetActive(true);
    }

    // ������ ��� ������ ������ (RawImage)
    public void BackToStart()
    {
        imageScreen.SetActive(false);
        rawImageScreen.SetActive(true);
    }
}