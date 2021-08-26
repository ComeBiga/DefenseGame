using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 10;
    public int damage = 3;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(Enemy enemy)
    {
        enemy.health -= damage;
    }
}
