using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrHazard : MonoBehaviour
{
    public GameObject projectile;
    GameObject player;
    public int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            health -= 10;
        }
    }
}
