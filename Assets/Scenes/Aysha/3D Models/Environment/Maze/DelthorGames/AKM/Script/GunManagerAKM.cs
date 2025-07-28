<<<<<<< HEAD
﻿
//edit
=======
>>>>>>> parent of 6948ba7 (aa)
using UnityEngine;

public class GunManagerAKM : MonoBehaviour
{
    public GameObject BulletPrefap;
    public Transform FirePoint;
    public float BulletSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject bullet = null;
            bullet = Instantiate(BulletPrefap, FirePoint.position, Quaternion.Euler(0,0,270));

            Rigidbody bulletPhyx = null;
            bulletPhyx = bullet.GetComponent<Rigidbody>();

            bulletPhyx.AddForce(FirePoint.forward * BulletSpeed, ForceMode.Impulse);

        }
    }
}
