using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    public Animator anim;
    public int health = 4;
   
    public Transform Camera;
    public AudioSource audioWalk;
    public AudioSource audioDie;
    private bool isDead = false;

    
    

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
            audioWalk.Play();
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enmey") && health > 0)
        {
                health--;
                
                if (health <= 0 && !isDead)
                {
                    isDead = true;
                    anim.Play("Dying");
                    audioDie.Play();
                    this.enabled = false;
                }
            
        }
    }
}










