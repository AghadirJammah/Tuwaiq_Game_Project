using UnityEngine;
using UnityEngine.AI;

public class EnmyChacing : MonoBehaviour
{
    // Start is called once before the first execution
    // of Update after the MonoBehaviour is created
    public Transform player;
    NavMeshAgent agent;
    public Animator anim;

    public float attackRange = 2f;
    public float chaseRange = 10f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= chaseRange)
        {
            agent.SetDestination(player.position);
            anim.Play("Zombie Run");
        }

        if (distance <= attackRange)
        {
            anim.Play("Zombie Attack");
        }

    }
    
}
