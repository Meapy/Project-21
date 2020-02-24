using UnityEngine;

public class FireBullets : MonoBehaviour
{
    public int bulletsAmount;
    public float startAngle;
    public float endAngle;
    private Vector2 bulletMoveDirection;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0.1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void Fire()
    {
        float bulletSpread = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            // End Point
            float bulletDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulletDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulletMoveVector = new Vector3(bulletDirX, bulletDirY, 0f);
            Vector2 bulletDir = (bulletMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<BirdBullet>().SetMoveDirection(bulletDir);

            angle += bulletSpread;
        }
    }
}

