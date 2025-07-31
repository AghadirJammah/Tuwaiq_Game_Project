using UnityEngine;

public class GunShow : MonoBehaviour
{

    [Header("Weapon Settings")]
    public GameObject weapon;

    void Start()
    {
        if (weapon != null)
            weapon.SetActive(false); 
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))  
        {
            if (weapon != null && !weapon.activeSelf)
                weapon.SetActive(true);
        }
        else // ��� ��� ����
        {
            if (weapon != null && weapon.activeSelf)
                weapon.SetActive(false);
        }
    }
}