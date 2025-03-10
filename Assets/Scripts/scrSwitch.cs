using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrSwitch : MonoBehaviour
{
    [SerializeField] scrDoor _doorBehavior;

    [SerializeField] bool _isDoorOpenSwitch;
    [SerializeField] bool _isDoorCloseSwitch;

    float _switchSizeY;
    Vector3 _switchUpPos;
    Vector3 _switchDownPos;
    float _switchSpeed = 1f;
    float _switchDelay = 0.2f;
    bool _isPressingSwitch = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _switchSizeY = transform.localScale.y / 2;

        _switchUpPos = transform.position;
        _switchDownPos = new Vector3(transform.position.x,
            transform.position.y - _switchSizeY, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (_isPressingSwitch)
        {
            MoveSwitchDown();
        }
        else if (!_isPressingSwitch)
        {
            MoveSwitchUp();
        }
    }

    void MoveSwitchDown()
    {
        if (transform.position != _switchDownPos)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                _switchDownPos, _switchSpeed * Time.deltaTime);
        }
    }

    void MoveSwitchUp()
    {
        if (transform.position != _switchUpPos)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                _switchUpPos, _switchSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _isPressingSwitch = !_isPressingSwitch;

            if (_isDoorOpenSwitch && !_doorBehavior._isDoorOpen)
            {
                _doorBehavior._isDoorOpen = !_doorBehavior._isDoorOpen;
            }

            else if (_isDoorCloseSwitch && !_doorBehavior._isDoorOpen)
            {
                _doorBehavior._isDoorOpen = !_doorBehavior._isDoorOpen;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(SwitchUpDelay(_switchDelay));
        }
    }

    IEnumerator SwitchUpDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        _isPressingSwitch = false;
    }
}
