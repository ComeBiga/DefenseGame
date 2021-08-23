using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Transform target;

    public int damage;
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            Destroy(this.gameObject);

        MoveTowardTarget();
    }

    void MoveTowardTarget()
    {
        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    public void Hit(Enemy enemy)
    {
        enemy.TakeDamage(damage);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Hit(collision.GetComponent<Enemy>());
            Destroy(this.gameObject);
        }
    }
}
