using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrHazard2 : MonoBehaviour
{
    public float frequency = 1.0f;
    public GameObject box;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(Spawn());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds delay = new WaitForSeconds(frequency);

        while (true)
        {
            yield return delay;

            Instantiate(box, transform.position, Quaternion.identity);
            Destroy(Instantiate(box, transform.position, Quaternion.identity), 2f);
        }
    }
}
