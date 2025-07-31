using System;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator anim;
    public int health = 4;
    public GameObject Player;

    public float damageCooldown = 1.0f; // ÇáãÏÉ Èíä ÇáÖÑÈÇÊ
    private float lastDamageTime = 0f;
    private bool isDead = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet") && !isDead)
        {
            if (Time.time - lastDamageTime > damageCooldown)
            {
                lastDamageTime = Time.time;

                health--;
                Debug.Log("Health: " + health);

                if (health <= 0)
                {
                    isDead = true;
                    anim.Play("Dying");
                    Debug.Log("ÇáÚÏæ ãÇÊ");
                    // äÈÏÃ ßÑæÊíäÉ áÍÐÝ ÇáÚÏæ ÈÚÏ ÇäÊåÇÁ ÇáÃäãíÔä
                    StartCoroutine(DieAfterDelay(2f)); // ÇÝÊÑÖäÇ Ãä ÇáÃäãíÔä ãÏÊå 2 ËÇäíÉ
                }
            }
        }
    }

    System.Collections.IEnumerator DieAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }

    internal void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }
}
