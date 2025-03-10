using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrHazard : MonoBehaviour
{
    public GameObject projectile;
    GameObject player;
    public float health = 100f;
    AudioSource soundEffects;
    public AudioClip[] sounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            health -= 10f;
            soundEffects.clip = sounds[0];
            soundEffects.Play();
        }

        if (other.CompareTag("Wall"))
        {
            Destroy(projectile);
        }
    }
}
