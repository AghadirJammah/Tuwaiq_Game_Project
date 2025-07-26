using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public Animator anim;
    public float rotationSpeed = 5f; // تحكم بسرعة الالتفاف

    void Update()
    {
        Vector3 move = Vector3.zero;
        Vector3 targetDirection = Vector3.zero;

        // إذا ضغط W نبدأ الانيميشن ونستقبل اتجاهات الأسهم
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

        // إذا فيه اتجاه نتحرك له
        if (targetDirection != Vector3.zero)
        {
            // التدوير التدريجي نحو الاتجاه
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            move = targetDirection;
        }

        // تحريك اللاعب
        controller.Move(move.normalized * speed * Time.deltaTime);
    }
}






