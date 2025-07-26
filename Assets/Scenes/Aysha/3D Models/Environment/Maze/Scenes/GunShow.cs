using UnityEngine;

public class GunShow : MonoBehaviour
{

    [Header("Weapon Settings")]
    public GameObject weapon; // ÇÓÍÈ ÇáÓáÇÍ åäÇ

    void Start()
    {
        if (weapon != null)
            weapon.SetActive(false); // ÅÎİÇÁ ÚäÏ ÇáÈÏÁ
    }

    void Update()
    {
        // íÙåÑ ÚäÏ ÇáÖÛØ Úáì W æáÇ íÎÊİí ÈÚÏåÇ
        if (Input.GetKeyDown(KeyCode.W) && !weapon.activeSelf)
        {
            weapon.SetActive(true); // ÊİÚíá äåÇÆí
        }
    }
}