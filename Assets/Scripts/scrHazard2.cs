using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrHazard2 : MonoBehaviour
{
    public float frequency = 1.0f;
    public GameObject box;

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
