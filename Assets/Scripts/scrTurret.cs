using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrTurret : MonoBehaviour
{
    public GameObject projectile;
    bool shootNow = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("ShootProjectile", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootProjectile()
    {
        if (shootNow)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            shootNow = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            shootNow = false;
        }
    }
}
