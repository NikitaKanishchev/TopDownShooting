using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public int damage = 40;
    public GameObject bulletPrefab;
    
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) Shoot();
    }

    void Shoot()
    {
        // shooting logic
        RaycastHit2D hitInfo = Physics2D.Raycast(FirePoint.position, FirePoint.right);

        if (hitInfo)
        {
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            if (enemy != null) enemy.TakeDamage(damage);

            Instantiate(bulletPrefab, hitInfo.point, Quaternion.identity);
        }
    }
}
