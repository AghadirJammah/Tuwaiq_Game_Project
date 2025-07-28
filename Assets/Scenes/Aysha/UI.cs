using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

 // «·⁄‰«’— «·—∆Ì”Ì…
    public GameObject rawImageScreen;  // «·‘«‘… «·√Ê·Ï ( Õ ÊÌ ⁄·Ï “— «·»œ«Ì…)
    public GameObject imageScreen;     // «·‘«‘… «·À«‰Ì… ( Õ ÊÌ ⁄·Ï 3 √“—«—)
    public GameObject howToPlayPanel;  // ‘«‘… «· ⁄·Ì„« 
    public GameObject gamePanel;       // ‘«‘… «··⁄»… «·—∆Ì”Ì…

    void Start()
    {
        // «· √ﬂœ „‰ √‰ ﬂ· «·‘«‘«  „⁄ÿ·… ≈·« «·‘«‘… «·√Ê·Ï
        rawImageScreen.SetActive(true);
        imageScreen.SetActive(false);
        howToPlayPanel.SetActive(false);
        gamePanel.SetActive(false);
    }

    // «·«‰ ﬁ«· „‰ RawImage ≈·Ï Image («·‘«‘… «·—∆Ì”Ì…)
    public void GoToImageScreen()
    {
        rawImageScreen.SetActive(false);
        imageScreen.SetActive(true);
    }

    // «·«‰ ﬁ«· ≈·Ï ‘«‘… «· ⁄·Ì„« 
    public void ShowHowToPlay()
    {
        imageScreen.SetActive(false);
        howToPlayPanel.SetActive(true);
    }

    // »œ¡ «··⁄»… («·–Â«» ≈·Ï Game Panel)
    public void StartGame()
    {
        imageScreen.SetActive(false);
        gamePanel.SetActive(true);
    }

    // «·⁄Êœ… ≈·Ï «·‘«‘… «·—∆Ì”Ì… (Image Screen)
    public void BackToMain()
    {
        howToPlayPanel.SetActive(false);
        gamePanel.SetActive(false);
        imageScreen.SetActive(true);
    }

    // «·⁄Êœ… ≈·Ï «·‘«‘… «·√Ê·Ï (RawImage)
    public void BackToStart()
    {
        imageScreen.SetActive(false);
        rawImageScreen.SetActive(true);
    }
}