using UnityEngine;

public class GunShow : MonoBehaviour
{

    [Header("Weapon Settings")]
    public GameObject weapon; // ���� ������ ���

    void Start()
    {
        if (weapon != null)
            weapon.SetActive(false); // ����� ��� �����
    }

    void Update()
    {
        // ���� ��� ����� ��� W ��� ����� �����
        if (Input.GetKeyDown(KeyCode.W) && !weapon.activeSelf)
        {
            weapon.SetActive(true); // ����� �����
 �������}
    }
}