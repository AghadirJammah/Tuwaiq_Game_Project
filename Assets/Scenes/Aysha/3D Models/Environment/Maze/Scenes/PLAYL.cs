using UnityEngine;

public class PLAYL : MonoBehaviour
{

    public Rigidbody PlayerPhyx;
    public int PlayerSpeed =5;
    public int PlayerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.RightArrow))
        {
            PlayerPhyx.linearVelocity = new Vector3(PlayerSpeed, PlayerPhyx.linearVelocity.y, 0);

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerPhyx.linearVelocity = new Vector3(-PlayerSpeed, PlayerPhyx.linearVelocity.y, 0);

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            PlayerPhyx.linearVelocity = new Vector3(0, PlayerPhyx.linearVelocity.y, PlayerSpeed);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            PlayerPhyx.linearVelocity = new Vector3(0, PlayerPhyx.linearVelocity.y, -PlayerSpeed);

        }
        else
        {
            PlayerPhyx.linearVelocity = new Vector3(0, PlayerPhyx.linearVelocity.y, PlayerPhyx.linearVelocity.z);
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
            PlayerHealth--;
            if (PlayerHealth == 0)
            {
                gameObject.SetActive(false);
            }
            else
            {
                other.gameObject.SetActive(false);
                Debug.Log("Damg ");

            }

        }

    }


}

