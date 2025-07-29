using UnityEngine;

public class PlayerController : MonoBehaviour
{
<<<<<<< HEAD
    public CharacterController controller;
    public float speed = 20f;
    public float rotationSpeed = 20f;
=======
    public Rigidbody rb;
    public float speed = 5f;
    public float rotationSpeed = 5f;
>>>>>>> 2508671d8d8433d7804ab93df8890cac172a51f3
    public Animator anim;
    public int health = 4;
    public GameObject Player;

    public float damageCooldown = 1.0f; // المدة بين الضربات
    private float lastDamageTime = 0f;
    private bool isDead = false;

<<<<<<< HEAD
=======
    private Vector3 moveDirection;
    private Vector3 smoothVelocity = Vector3.zero;
    public float smoothTime = 0.1f;

>>>>>>> 2508671d8d8433d7804ab93df8890cac172a51f3
    void Update()
    {
        if (isDead) return;

        Vector3 move = Vector3.zero;
        Vector3 targetDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            anim.Play("Shooting");

            if (Input.GetKey(KeyCode.UpArrow))
                targetDirection = transform.forward;
            else if (Input.GetKey(KeyCode.DownArrow))
                targetDirection = -transform.forward;
            else if (Input.GetKey(KeyCode.RightArrow))
                targetDirection = transform.right;
            else if (Input.GetKey(KeyCode.LeftArrow))
                targetDirection = -transform.right;
        }
        else
        {
            anim.Play("idle");
        }

        if (targetDirection != Vector3.zero)
        {
<<<<<<< HEAD
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            move = targetDirection;
=======
            // دوران ناعم باستخدام Slerp
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // تحريك ناعم باستخدام SmoothDamp
            Vector3 targetPosition = rb.position + (targetDirection.normalized * speed * Time.deltaTime);
            Vector3 smoothPosition = Vector3.SmoothDamp(rb.position, targetPosition, ref smoothVelocity, smoothTime);
            rb.MovePosition(smoothPosition);
>>>>>>> 2508671d8d8433d7804ab93df8890cac172a51f3
        }

        controller.Move(move.normalized * speed * Time.deltaTime);
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








<<<<<<< HEAD
=======


>>>>>>> 2508671d8d8433d7804ab93df8890cac172a51f3
