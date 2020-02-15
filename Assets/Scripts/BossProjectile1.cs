using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectile1 : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;

    private Transform player;

    private Vector2 target;
    public LayerMask whatIsSolid;

    public int damage;
    public GameObject destroyEffect;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);

        Invoke("DestroyProjectile", lifetime);

    }

    void Update() {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);


        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Player"))
            {
                Debug.Log("Player Must Take Damage!");
                hitInfo.collider.GetComponent<PlayerControl>().TakeDamage(damage);
            }
            DestroyProjectile();
        }

    }

    void DestroyProjectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectile1 : MonoBehaviour
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
            if (hitInfo.collider.CompareTag("Player"))
            {
                Debug.Log("Player Must Take Damage!");
                hitInfo.collider.GetComponent<PlayerControl>().TakeDamage(damage);
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
*/
