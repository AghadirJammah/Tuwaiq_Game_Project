using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;

public class EnmyChacing : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    public Animator anim;

    public float attackRange = 2f;
    public float chaseRange = 15f;

    public AudioSource audioSource;

    private bool isAttacking = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // ·«  ‘ €· «··⁄»… ≈–« «·Êﬁ  „ Êﬁ›
        if (Time.timeScale == 0f)
            return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= attackRange)
        {
            // «·ÂÃÊ„
            anim.Play("Zombie Attack");

            if (!isAttacking)
            {
                audioSource.Play();
                isAttacking = true;
            }

            // ≈Ìﬁ«› Õ—ﬂ… «·⁄œÊ √À‰«¡ «·ÂÃÊ„
            agent.ResetPath();
        }
        else if (distance <= chaseRange)
        {
            // «·„ÿ«—œ…
            agent.SetDestination(player.position);
            anim.Play("Zombie Run");

            isAttacking = false;
        }
        else
        {
            // «‰ Ÿ«— (Idle) ≈–« «··«⁄» »⁄Ìœ
            agent.ResetPath();
            anim.Play("Zombie Idle"); //  √ﬂœ √‰ ·œÌﬂ √‰Ì„Ì‘‰ »«”„ Idle √Ê €Ì¯— «·«”„ »„« Ì‰«”»ﬂ
            isAttacking = false;
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


