using UnityEngine;

public class GUNS : MonoBehaviour
{

    public GameObject bulletPrefab;  // «·‹ Prefab «·Œ«’ »«·—’«’…
    public Transform firePoint;      // «·„ﬂ«‰ «·–Ì Ìÿ·ﬁ „‰Â «·—’«’
    public float fireRate = 0.5f;    // ”—⁄… «·≈ÿ·«ﬁ („À«·: ﬂ· ‰’› À«‰Ì…)

    private float nextFireTime = 0f; // Êﬁ  «·≈ÿ·«ﬁ «· «·Ì

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFireTime)  // ⁄‰œ„«  ÷€ÿ “— «·„«Ê” «·√Ì”—
        {
            nextFireTime = Time.time + fireRate; //  ÕœÌÀ Êﬁ  «·≈ÿ·«ﬁ «· «·Ì
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
