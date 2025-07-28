using UnityEngine;
// edit
public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    public float rotationSpeed = 10f;
    public Animator anim;
    public int health = 4;
    public GameObject Player;

    public float damageCooldown = 1.0f;
    private float lastDamageTime = 0f;
    private bool isDead = false;

    private Vector3 moveDirection;

    void Update()
    {
        if (isDead) return;

        moveDirection = Vector3.zero;
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
            // دوران اللاعب باتجاه الحركة
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // تحريك اللاعب
            moveDirection = targetDirection.normalized * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + moveDirection);
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









