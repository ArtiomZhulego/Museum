using UnityEngine;

public class BorderLightSlider : MonoBehaviour
{
    private Transform _transform;
    public Light lightObject;

    private void Start()
    {
        _transform = GetComponent<Transform>();

        // Подписываемся на событие OnObjectMoved
        LightSlider.OnObjectMoved += SaveBrightness;

        // Восстанавливаем сохраненное значение яркости
        float savedBrightness = PlayerPrefs.GetFloat("brightness", 50000f);
        SetLightIntensity(savedBrightness);
    }

    void FixedUpdate()
    {
        // Ограничение перемещения по оси X
        if (_transform.position.x > -12.2f)
        {
            _transform.position = new Vector3(-12.2f, 9.35f, -3.70f);
        }
        if (_transform.position.x < -6.56f)
        {
            _transform.position = new Vector3(-6.56f, 9.35f, -3.70f);
        }
    }

    private void OnDestroy()
    {
        // Отписываемся от события OnObjectMoved при уничтожении объекта
        LightSlider.OnObjectMoved -= SaveBrightness;
    }

    private void SaveBrightness()
    {
        // Вычисление и сохранение значения яркости
        float normalizedBrightness = Mathf.InverseLerp(-12.2f, -6.56f, _transform.position.x);
        float scaledBrightness = Mathf.Lerp(0f, 50000f, normalizedBrightness);
        PlayerPrefs.SetFloat("brightness", scaledBrightness);
        PlayerPrefs.Save();

        // Изменяем значение яркости света
        SetLightIntensity(scaledBrightness);
    }

    private void SetLightIntensity(float brightness)
    {
        // Настройка интенсивности света
        lightObject.intensity = brightness;
    }
}