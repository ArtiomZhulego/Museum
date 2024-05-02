using UnityEngine;

public class borderSlider : MonoBehaviour
{
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();

        // ������������� �� ������� OnObjectMoved
        volumeSlider.OnObjectMoved += SaveVolume;
    }

    void FixedUpdate()
    {
        // ����������� ����������� �� ��� X
        if (_transform.position.x > -6.56f)
        {
            _transform.position = new Vector3(-6.56f, 9.35f, -3.70f);
        }
        if (_transform.position.x < -12.2f)
        {
            _transform.position = new Vector3(-12.2f, 9.35f, -3.70f);
        }

        // ����������� ����������� �� ��� Y
        if (_transform.position.y != 9.3f)
        {
            _transform.position = new Vector3(_transform.position.x, 9.3f, -3.70f);
        }
    }

    private void OnDestroy()
    {
        // ������������ �� ������� OnObjectMoved ��� ����������� �������
        volumeSlider.OnObjectMoved -= SaveVolume;
    }

    private void SaveVolume()
    {
        // ���������� � ���������� �������� ���������
        float normalizedVolume = Mathf.InverseLerp(-6.7f, -12.3f, _transform.position.x);
        float scaledVolume = Mathf.Lerp(0f, 1f, normalizedVolume);
        PlayerPrefs.SetFloat("totalVolume", scaledVolume);
        PlayerPrefs.Save();
    }
}