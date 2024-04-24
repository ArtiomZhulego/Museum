using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class RaycastPicture : MonoBehaviour
{
    public TMP_Text CanvasText;
    void Update()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,40);

        if (hit.collider == null) CanvasText.text = String.Empty;
        else
        {
            switch (hit.collider.gameObject.tag)
            {
                case "Belarus":
                    CanvasText.text = "H������ <color=orange>�</color> ��� ����������� � ��� �������-�������������� �������� ���������� ��������";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("http://ggaek.by/" + Application.identifier);
                    }
                    break;
                case "Cinema":
                    CanvasText.text = "H������ <color=green>�</color> ��� ����������� � ��� ���������� ��������";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(3);
                    }
                    break;
                case "Kitchen":
                    CanvasText.text = "H������ <color=green>�</color> ��� ����������� �� ����� ���������� ��������";
                    break;
                case "ArtGalery":
                    CanvasText.text = "H������ <color=green>�</color> ��� ���������� � ����� �������� ���������� ��������";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(4);
                    }
                    break;
                case "Finish":
                    CanvasText.text = "�� ����������� ��� ��������� �������, ��� ������ � �������� ���� ���������� ������ <color=green>�</color>";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene("StartScene");
                        Cursor.lockState = CursorLockMode.Confined;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
