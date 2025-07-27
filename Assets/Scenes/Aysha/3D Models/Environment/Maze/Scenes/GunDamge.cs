using UnityEngine;

public class GunDamge : MonoBehaviour
{



    public int damage = 50;   // 🔥 كل طلقة تسبب 50 دامج
    public float lifeTime = 3f;

    void Start()
    {
        Destroy(gameObject, lifeTime);  // حذف الرصاصة بعد وقت
    }

    void OnCollisionEnter(Collision collision)
    {
        // نحاول نجيب سكربت EnemyHealth من الجسم المصطدم
        EnemyHelth enemy = collision.gameObject.GetComponent<EnemyHelth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);  // ⚡ ضرر 50 لكل طلقة
        }

        Destroy(gameObject);  // حذف الرصاصة بعد التصادم
    }
}
