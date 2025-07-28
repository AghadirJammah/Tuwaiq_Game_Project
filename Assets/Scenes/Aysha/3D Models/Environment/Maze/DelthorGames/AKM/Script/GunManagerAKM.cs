
//edit
using UnityEngine;

public class GunManagerAKM : MonoBehaviour
{
    public GameObject BulletPrefap;
    public Transform FirePoint;
    public float BulletSpeed;
    public AudioSource audioSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }

            GameObject bullet = Instantiate(BulletPrefap, FirePoint.position, FirePoint.rotation); // استخدم نفس دوران فوهة السلاح
            Rigidbody bulletPhyx = bullet.GetComponent<Rigidbody>();

            bulletPhyx.AddForce(FirePoint.forward * BulletSpeed, ForceMode.Impulse);
        }
    }
}

