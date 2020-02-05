
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public LayerMask whatIsSolid;

    public int damage;
  

    public GameObject destroyEffect;

    // Start is called before the first frame update
    void Start()
    { 
      Invoke("DestroyProjectile", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                Debug.Log("Enemy Must Take Damage!");
                hitInfo.collider.GetComponent<BossControl>().TakeDamage(damage);
            }
            DestroyProjectile();
        }

        transform.Translate(Vector2.up * speed * Time.deltaTime);
//      transform.position += transform.up * speed * Time.deltaTime; Does same as line above 
    }
    
    void DestroyProjectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
