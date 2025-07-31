using UnityEngine;

public class GunManagerAKM : MonoBehaviour
{
    public GameObject BulletPrefap;         
    public GameObject muzzleFlashPrefab;    
    public Transform FirePoint;             
    public float BulletSpeed = 20f;          
    public AudioSource audioSource;         

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            
            if (audioSource != null)
            {
                audioSource.Play();
            }

            
            GameObject bullet = Instantiate(BulletPrefap, FirePoint.position, FirePoint.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            if (bulletRb != null)
            {
                bulletRb.AddForce(FirePoint.forward * BulletSpeed, ForceMode.Impulse);
            }

            
            if (muzzleFlashPrefab != null)
            {
                GameObject flash = Instantiate(muzzleFlashPrefab, FirePoint.position, FirePoint.rotation);
                ParticleSystem ps = flash.GetComponent<ParticleSystem>();
                if (ps != null)
                {
                    ps.Play();
                }
                Destroy(flash, 0.1f); 
            }
        }
    }
}


