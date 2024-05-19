using UnityEngine;
using UnityEngine.UI;

public class ColliderPanelController : MonoBehaviour
{
    public GameObject panelGameObject;
    public Text[] panelTexts; // Массив текстовых элементов на панели

    private void OnTriggerEnter(Collider other)
    {
        // Активируем панель и обновляем текст в соответствии с объектом
        panelGameObject.SetActive(true);
        UpdatePanelText(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        // Деактивируем панель, когда игрок выходит из коллайдера
        panelGameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelGameObject.SetActive(false);
        }
    }

    private void UpdatePanelText(string objectName)
    {
        switch (objectName)
        {
            case "Bookcase1":
                panelTexts[0].text = "1. Зима в избушке";
                panelTexts[1].text = "Дополнительная информация";
                break;
            case "Bookcase2":
                panelTexts[0].text = "Информация для Object2";
                panelTexts[1].text = "Другая дополнительная информация";
                break;
            default:
                break;
        }
    }
}