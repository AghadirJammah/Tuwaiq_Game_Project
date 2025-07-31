using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    [Header("Movement Settings")]
    public CharacterController controller;
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public Animator anim;
    public int health = 4;

    [Header("Combat Settings")]
    public float damageCooldown = 1.0f;
    private float lastDamageTime = 0f;
    private bool isDead = false;

    void Update()
    {
        if (isDead) return;

        HandleMovement();
        HandleAnimation();
        LockPositionY(); // يمنع أي ارتفاع
    }

    void HandleMovement()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
            move = transform.forward;
        else if (Input.GetKey(KeyCode.DownArrow))
            move = -transform.forward;
        else if (Input.GetKey(KeyCode.RightArrow))
            move = transform.right;
        else if (Input.GetKey(KeyCode.LeftArrow))
            move = -transform.right;

        if (move != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            controller.Move(move.normalized * speed * Time.deltaTime);
        }
    }

    void HandleAnimation()
    {
        anim.Play(Input.GetKey(KeyCode.W) ? "Shooting" : "idle");
    }

    void LockPositionY()
    {
        // إجبار اللاعب على البقاء في ارتفاع ثابت
        Vector3 pos = transform.position;
        pos.y = 0; // أو أي قيمة تريدها
        transform.position = pos;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && health > 0 && Time.time - lastDamageTime > damageCooldown)
        {
            lastDamageTime = Time.time;
            health--;

            if (health <= 0)
            {
                isDead = true;
                anim.Play("Dying");
                this.enabled = false;
            }
        }
    }
}