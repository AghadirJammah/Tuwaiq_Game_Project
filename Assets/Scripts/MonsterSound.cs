using UnityEngine;

public class MonsterSound : MonoBehaviour
{
    public Transform player;
    public float soundRange = 10f;

    public AudioSource audioRun;
    private bool hasPlayed = false;

    void Start()
    {
        
    }

    void Update()
    {
        // ✅ لا تفعل شيء إذا اللعبه ما بدأت (موقفه)
        if (Time.timeScale == 0f)
            return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= soundRange)
        {
            if (!hasPlayed)
            {
                audioRun.Play();
                hasPlayed = true;
            }
        }
        else
        {
            hasPlayed = false;
        }
    }
}
