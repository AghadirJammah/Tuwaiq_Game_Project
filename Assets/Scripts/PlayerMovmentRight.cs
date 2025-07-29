using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public Animator anim;
    public int health = 4;
    public GameObject Player;
    public Transform Camera;

    public float damageCooldown = 1.0f;
    private float lastDamageTime = 0f;
    private bool isDead = false;

    private Vector3 moveDirection;
    private Vector3 smoothVelocity = Vector3.zero;
    public float smoothTime = 0.1f;

    void Update()
    {
        if (isDead) return;

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movePose = Vector3.zero;
        movePose = transform.forward * inputY + transform.right * inputX;
        rb.linearVelocity += movePose * speed * Time.deltaTime;

        float inputXM = Input.GetAxis("Mouse X");
        transform.localEulerAngles += new Vector3(0, inputXM,0);

        float inputYM = Input.GetAxis("Mouse Y");
        Camera.localEulerAngles -= new Vector3(inputYM, 0, 0);

        if(inputX == 0 && inputY == 0)
        {
            rb.linearVelocity = Vector3.zero;
            anim.Play("idle");

        }
        else
        {
            anim.Play("Shooting");
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enmey") && health > 0)
        {
            if (Time.time - lastDamageTime > damageCooldown)
            {
                lastDamageTime = Time.time;

                health--;
                Debug.Log("Health: " + health);

                if (health <= 0 && !isDead)
                {
                    isDead = true;
                    anim.Play("Dying");
                    Debug.Log("اللاعب مات");
                    this.enabled = false;
                }
            }
        }
    }
}










