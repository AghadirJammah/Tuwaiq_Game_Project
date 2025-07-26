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
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= 2f) // Ãæ ÇáãÓÇÝÉ Çááí ÊÈí
        {
            anim.Play("Zombie Attack");
        }
        else
        {
            anim.Play("Zombie Run");
        }

    }
    
}
