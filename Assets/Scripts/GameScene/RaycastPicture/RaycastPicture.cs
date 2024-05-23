using System;
using TMPro;
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
                /*case "Bookcase":
                    CanvasText.text = "H������ <color=green>�</color> ��� ���������� � �����������";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(5);
                    }
                    break;*/
                case "BookcaseSummer":
                    CanvasText.text = "H������ <color=green>�</color> ��� ���������� � ��������� � ����";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("https://vk.com/video-54443855_168050768" + Application.identifier);
                    }
                        break;
                case "BookcaseAutumn":
                    CanvasText.text = "H������ <color=green>�</color> ��� ���������� � ��������� � �����";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("https://www.youtube.com/watch?v=w66cJV5k3Rk&t=60s" + Application.identifier);
                    }
                    break;
                case "BookcaseWinter":
                    CanvasText.text = "H������ <color=green>�</color> ��� ���������� � ��������� � ����";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("https://www.youtube.com/watch?v=9ZQ43LLjLfY&t=7s" + Application.identifier);
                    }
                    break;
                case "BookcaseSpring":
                    CanvasText.text = "H������ <color=green>�</color> ��� ���������� � ��������� � �����";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("https://vk.com/video/@sovmultinfo" + Application.identifier);
                    }
                    break;
                case "BookcaseAll":
                    CanvasText.text = "H������ <color=green>�</color> ��� ���������� � ������������ ��� ������� ����";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("https://www.youtube.com/watch?v=1PVZGivbAOY" + Application.identifier);
                    }
                    break;
                case "LeaveSCENE":
                    CanvasText.text = "H������ <color=green>�</color> ��� ������ �� ������ �����";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(2);
                    }
                    break;
                case "SignSCE":
                    CanvasText.text = "H������ <color=green>�</color> ��� ���������� � ��������� ������";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(5);
                    }
                    break;
            }
        }
    }
}
