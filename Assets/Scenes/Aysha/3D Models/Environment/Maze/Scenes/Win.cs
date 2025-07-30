using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Canvas;      // «·ﬂ«‰›” «··Ì ›ÌÂ “— «·›Ê“
    public GameObject Canvas1;     // «·ﬂ«‰›” «··Ì ›ÌÂ «·ﬁ«∆„…
    public GameObject Image;
    public GameObject Panel;// «·‹ Child «··Ì «”„Â Menu œ«Œ· mainCanvas

    public void OpenMenuFromWin()
    {
        Canvas.SetActive(false);
        Canvas1.SetActive(true);
        Image.SetActive(true);
    }
    public void GoToPanel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}

