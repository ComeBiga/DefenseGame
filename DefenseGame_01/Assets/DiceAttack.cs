using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceAttack : MonoBehaviour
{
    public GameObject projectile;

    public int damage = 10;

    GameObject curProjectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(curProjectile == null)
        {
            ShootProjectile();
        }
    }

    void ShootProjectile()
    {
        curProjectile = Instantiate(projectile, transform);
        curProjectile.GetComponent<Projectile>().target = GameObject.FindGameObjectWithTag("Enemy").transform;
        curProjectile.GetComponent<Projectile>().damage = damage;
    }
}
