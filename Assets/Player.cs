using UnityEngine;

public class Player : MonoBehaviour
{

    public static int health = 100;

    public GameObject deathEffetc;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Player player =     
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        

        if (health <= damage) Die();
        
    }

    void Die()
    {
        Instantiate(deathEffetc, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
