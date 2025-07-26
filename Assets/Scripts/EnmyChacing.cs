using UnityEngine;
using UnityEngine.AI;

public class EnmyChacing : MonoBehaviour
{
    // Start is called once before the first execution
    // of Update after the MonoBehaviour is created
    public Transform player;
    public NavMeshAgent agent;
    public Animator anim;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);

    }
    void OnTriggerEnter(Collider other)

    {


        if (other.CompareTag("Player"))

        {
            anim.Play("Zombie Attack");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.Play("Zombie Run");
        }
    }
}
