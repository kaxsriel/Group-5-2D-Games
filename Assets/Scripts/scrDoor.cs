using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrDoor : MonoBehaviour
{
    public bool _isDoorOpen = false;
    Vector3 _doorClosedPos;
    Vector3 _doorOpenPos;
    float _doorSpeed = 10f;
    AudioSource soundEffects;
    public AudioClip[] sounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _doorClosedPos = transform.position;
        _doorOpenPos = new Vector3(transform.position.x,
            transform.position.y + 3f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (_isDoorOpen)
        {
            OpenDoor();
            soundEffects.clip = sounds[0];
            soundEffects.Play();
        }
        else if (!_isDoorOpen)
        {
            CloseDoor();
            soundEffects.clip = sounds[1];
            soundEffects.Play();
        }
    }

    void OpenDoor()
    {
        if (transform.position != _doorOpenPos)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                _doorOpenPos, _doorSpeed * Time.deltaTime);
        }
    }

    void CloseDoor()
    {
        if (transform.position != _doorClosedPos)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                _doorClosedPos, _doorSpeed * Time.deltaTime);
        }
    }
}
