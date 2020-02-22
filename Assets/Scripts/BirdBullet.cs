using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBullet : MonoBehaviour
{
    private Vector2 moveDirection;
    public float bulletSpeed;


    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * bulletSpeed * Time.deltaTime);
    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    private void OnDestroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();        
    }
}
