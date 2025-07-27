using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class EnemyHelth : MonoBehaviour
{

    public int health = 100;  // íãæÊ ÈÚÏ ØáŞÊíä (50 + 50)

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("ÇáÚÏæ ÃÎĞ ÏÇãÌ¡ ÇáÕÍÉ ÇáÂä: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("ÇáÚÏæ ãÇÊ!");
        Destroy(gameObject);
    }
}

