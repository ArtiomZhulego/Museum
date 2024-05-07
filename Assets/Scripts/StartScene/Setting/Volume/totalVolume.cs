using UnityEngine;

public class totalVolume : MonoBehaviour
{
    public GameObject checkBox;
    public GameObject slider;
    private float initialVolume = 1f;

    private void Start()
    {
        // Проверяем, сохранено ли значение громкости
        if (PlayerPrefs.HasKey("totalVolume"))
        {
            float savedVolume = PlayerPrefs.GetFloat("totalVolume");

            // Устанавливаем сохраненное значение громкости
            SetVolume(savedVolume);
        }
        else
        {
            // Если значение громкости не сохранено, устанавливаем громкость по умолчанию
            SetVolume(initialVolume);
        }
    }

    private void OnMouseDown()
    {
        float currentVolume = AudioListener.volume;

        if (currentVolume > 0)
        {
            SetVolume(0f);
        }
        else
        {
            SetVolume(initialVolume);
        }
    }

    private void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("totalVolume", volume);
        PlayerPrefs.Save();

        checkBox.SetActive(volume > 0);
        slider.SetActive(volume > 0);
    }
}