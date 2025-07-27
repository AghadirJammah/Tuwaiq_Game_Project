using UnityEngine;

public class GUNS : MonoBehaviour
{

    public GameObject bulletPrefab;  // ��� Prefab ����� ��������
    public Transform firePoint;      // ������ ���� ���� ��� ������
    public float fireRate = 0.5f;    // ���� ������� (����: �� ��� �����)

    private float nextFireTime = 0f; // ��� ������� ������

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFireTime)  // ����� ���� �� ������ ������
        {
            nextFireTime = Time.time + fireRate; // ����� ��� ������� ������
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
