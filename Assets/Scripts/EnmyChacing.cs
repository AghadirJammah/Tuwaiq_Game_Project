using UnityEngine;
using UnityEngine.AI;
using System.Collections;
//edit

public class EnmyChacing : MonoBehaviour
{
    // Start is called once before the first execution
    // of Update after the MonoBehaviour is created
    public Transform player;
    NavMeshAgent agent;
    public Animator anim;

    public float attackRange = 1f;
    
    public AudioSource audioS1;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= attackRange)
        {
            
            anim.Play("Zombie Attack");
            

        }
        else
        {
            
            agent.SetDestination(player.position);
            audioS1.Play();
            anim.Play("Zombie Run");

        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            gameObject.SetActive(false); 
        }
    }


}




