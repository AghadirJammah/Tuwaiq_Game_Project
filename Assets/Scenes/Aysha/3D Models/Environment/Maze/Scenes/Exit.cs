using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{


    public GameObject winScreen;   // ÔÇÔÉ ÇáİæÒ
    public GameObject player;      // ÇááÇÚÈ
    public GameObject restartButton;  // ÒÑ ÅÚÇÏÉ ÇááÚÈ
    public GameObject mainMenuButton; // ÒÑ ÇáÚæÏÉ Åáì ÇáÔÇÔÉ ÇáÑÆíÓíÉ

    void Start()
    {
        // ÅÎİÇÁ ÔÇÔÉ ÇáİæÒ ÚäÏ ÈÏÇíÉ ÇááÚÈÉ
        winScreen.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)  // ÊÍŞŞ ÅĞÇ ßÇä ÇááÇÚÈ åæ ÇáĞí ÏÎá ÇáãÎÑÌ
        {
            // ÅÙåÇÑ ÔÇÔÉ ÇáİæÒ ÚäÏ ÇáİæÒ
            Time.timeScale = 0;  // ÅíŞÇİ ÇááÚÈÉ
            winScreen.SetActive(true);  // ÅÙåÇÑ ÔÇÔÉ ÇáİæÒ
        }
    }

    // ÅÚÇÏÉ ÊÔÛíá ÇááÚÈÉ
    public void RestartGame()
    {
        Time.timeScale = 1; // ÇÓÊÆäÇİ ÇááÚÈÉ
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // ÅÚÇÏÉ ÊÍãíá ÇáãÔåÏ ÇáÍÇáí
    }

    // ÇáÚæÏÉ Åáì ÇáÔÇÔÉ ÇáÑÆíÓíÉ
    public void GoToMainMenu()
    {
        Time.timeScale = 1; // ÇÓÊÆäÇİ ÇááÚÈÉ
        SceneManager.LoadScene("MainMenu");  // Şã ÈÊÛííÑ ÇÓã ÇáãÔåÏ Åáì ÇáãÔåÏ ÇáÑÆíÓí
    }
}


