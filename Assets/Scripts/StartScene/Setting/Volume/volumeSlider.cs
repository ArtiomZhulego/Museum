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

            // Получение нормализованного значения громкости на основе позиции объекта
            float normalizedVolume = Mathf.InverseLerp(-6.7f, -12.3f, objectToMove.transform.position.x);

            // Масштабирование нормализованного значения громкости в интервал от 0 до 1
            float scaledVolume = Mathf.Lerp(0f, 1f, normalizedVolume);

            // Применение нового значения громкости к AudioSource
            audioSource.volume = scaledVolume;

            // Сохранение значения громкости
            PlayerPrefs.SetFloat("totalVolume", scaledVolume);
            PlayerPrefs.Save();
        }
    }
}