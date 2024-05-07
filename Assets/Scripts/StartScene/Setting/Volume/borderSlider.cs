using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderSlider : MonoBehaviour
{
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        if (_transform.position.x > -6.6f) 
        {
            _transform.position = new Vector3(-6.56f, 9.35f, -3.70f);
        }
        if (_transform.position.x < -12.3f)
        {
            _transform.position = new Vector3(-12.2f, 9.35f, -3.70f);
        }
        if (_transform.position.y != 9.3f)
        {
            _transform.position = new Vector3(_transform.position.x, 9.3f, -3.70f);
        }
        if (_transform.position.x < -6.7f && _transform.position.x > -12.3f)
        {
            PlayerPrefs.SetFloat("totalVolume", ((_transform.position.x - (-6.6f)) / -0.056f)/100);
            Debug.Log((_transform.position.x - (-6.6f)) / -0.056f);
        }


    }
}
