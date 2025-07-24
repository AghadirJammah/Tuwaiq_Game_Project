using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public Animator anim;




    void Update()
    {
        Vector3 move = Vector3.zero;

    if (Input.GetKey(KeyCode.W))
        {
            anim.Play("Shooting");
            if (Input.GetKey(KeyCode.UpArrow))
                move += transform.forward;

            if (Input.GetKey(KeyCode.DownArrow))
                move -= transform.forward;

            if (Input.GetKey(KeyCode.RightArrow))
                move += transform.right;

            if (Input.GetKey(KeyCode.LeftArrow))
                move -= transform.right;

        }
    else {
            anim.Play("idle");
        }
        
        

   
        
        controller.Move(move.normalized * speed * Time.deltaTime);

       
    }
}









