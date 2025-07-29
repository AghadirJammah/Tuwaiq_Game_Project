using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public Animator anim;
    public int health = 4;
    public GameObject Player;

    public float damageCooldown = 1.0f;
    private float lastDamageTime = 0f;
    private bool isDead = false;

    private Vector3 moveDirection;
    private Vector3 smoothVelocity = Vector3.zero;
    public float smoothTime = 0.1f;

    public AudioSource audioS2;

    void Update()
    {
        if (isDead) return;

        moveDirection = Vector3.zero;
        Vector3 targetDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            anim.Play("Shooting");

            if (Input.GetKey(KeyCode.UpArrow))
            {
                targetDirection = transform.forward;
                audioS2.Play();
            }

            else if (Input.GetKey(KeyCode.DownArrow))
            {


                targetDirection = -transform.forward;
                audioS2.Play();
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {


                targetDirection = transform.right;
                audioS2.Play();
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {


                targetDirection = -transform.right;
                audioS2.Play();
            }
        }
        else
        {
            anim.Play("idle");
        }

        if (targetDirection != Vector3.zero)
        {
            // دوران ناعم باستخدام Slerp
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // تحريك ناعم باستخدام SmoothDamp
            Vector3 targetPosition = rb.position + (targetDirection.normalized * speed * Time.deltaTime);
            Vector3 smoothPosition = Vector3.SmoothDamp(rb.position, targetPosition, ref smoothVelocity, smoothTime);
            rb.MovePosition(smoothPosition);
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










