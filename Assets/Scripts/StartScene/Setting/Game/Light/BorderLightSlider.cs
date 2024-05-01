using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderLightSlider : MonoBehaviour
{
    private Transform _transform;

    public Light targetLight;
    public float minPosition;
    public float maxPosition;
    public float minIntensity;
    public float maxIntensity;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        if (_transform.position.x > -6.6f)
        {
            _transform.position = new Vector3(-6.56f, 7.2f, -3.50f);
        }
        if (_transform.position.x < -12.2f)
        {
            _transform.position = new Vector3(-12f, 7.2f, -3.50f);
        }
        if (_transform.position.y != 7.2f)
        {
            _transform.position = new Vector3(_transform.position.x, 7.2f, -3.50f);
        }

        float t = Mathf.InverseLerp(minPosition, maxPosition, _transform.position.x);
        float intensity = Mathf.Lerp(minIntensity, maxIntensity, t);
        targetLight.intensity = intensity;
    }
}
