using UnityEngine;
using UnityEngine.UI;

public class ColliderPanelController : MonoBehaviour
{
    public GameObject panelGameObject;
    public Text[] panelTexts; // ������ ��������� ��������� �� ������

    private void OnTriggerEnter(Collider other)
    {
        // ���������� ������ � ��������� ����� � ������������ � ��������
        panelGameObject.SetActive(true);
        UpdatePanelText(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        // ������������ ������, ����� ����� ������� �� ����������
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
                panelTexts[0].text = "1. ���� � �������";
                panelTexts[1].text = "�������������� ����������";
                break;
            case "Bookcase2":
                panelTexts[0].text = "���������� ��� Object2";
                panelTexts[1].text = "������ �������������� ����������";
                break;
            default:
                break;
        }
    }
}