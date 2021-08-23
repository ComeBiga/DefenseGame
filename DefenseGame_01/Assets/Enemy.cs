using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
            Die();
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag == "Projectile")
    //    {
    //        collision.GetComponent<Projectile>().TakeDamage(this);
    //        Destroy(collision.gameObject);
    //    }
    //}
}
