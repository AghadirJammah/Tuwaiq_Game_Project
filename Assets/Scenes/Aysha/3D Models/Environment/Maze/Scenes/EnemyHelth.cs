using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class EnemyHelth : MonoBehaviour
{

    public int health = 100;  // ���� ��� ������ (50 + 50)

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("����� ��� ���̡ ����� ����: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("����� ���!");
        Destroy(gameObject);
    }
}

