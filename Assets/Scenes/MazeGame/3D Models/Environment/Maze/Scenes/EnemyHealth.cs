using System;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator anim;
    public int health = 4;
    public GameObject Player;

    public float damageCooldown = 1.0f; // ����� ��� �������
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
                    Debug.Log("����� ���");
                    // ���� ������� ���� ����� ��� ������ ��������
                    StartCoroutine(DieAfterDelay(2f)); // ������� �� �������� ���� 2 �����
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
