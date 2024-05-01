using UnityEngine;

public class volumeSlider : MonoBehaviour
{
    public GameObject objectToMove;
    public AudioSource audioSource;

    private void OnMouseDown()
    {
        UpdateVolume();
    }

    private void OnMouseDrag()
    {
        UpdateVolume();
    }

    private void UpdateVolume()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            objectToMove.transform.position = hit.point;

            // ��������� ���������������� �������� ��������� �� ������ ������� �������
            float normalizedVolume = Mathf.InverseLerp(-6.7f, -12.3f, objectToMove.transform.position.x);

            // ��������������� ���������������� �������� ��������� � �������� �� 0 �� 1
            float scaledVolume = Mathf.Lerp(0f, 1f, normalizedVolume);

            // ���������� ������ �������� ��������� � AudioSource
            audioSource.volume = scaledVolume;

            // ���������� �������� ���������
            PlayerPrefs.SetFloat("totalVolume", scaledVolume);
            PlayerPrefs.Save();
        }
    }
}