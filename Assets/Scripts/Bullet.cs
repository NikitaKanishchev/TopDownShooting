using UnityEngine;

public class Bullet : MonoBehaviour    
{

    public float speed = 15f;
    public int damage = 20;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    
    void Start() => rb.velocity = transform.right * speed;

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
       Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null) enemy.TakeDamage(damage);

        Instantiate(impactEffect, transform.position, transform.rotation);
        
    }
}
    