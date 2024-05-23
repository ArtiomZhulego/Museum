using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class LinkToVideo : MonoBehaviour
{
    public TMP_Text CanvasText;
    public Animator AnimalAnimator;

    void Update()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 40);

        if (hit.collider == null)
            CanvasText.text = String.Empty;
        else
        {
            switch (hit.collider.gameObject.tag)
            {
                case "DummyOne":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � ���������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://youtu.be/qo_wPKNMi4Q?si=b6E2QIwy2W4f5WE0");
                    break;
                case "DummyTwo":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � ������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL(" https://youtu.be/Q1qevWcfA6k?si=_-OZUfSbQg7NcAS9");
                    break;
                case "DummyThree":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � ��������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://youtu.be/LfVhzWu0650?si=FRw-qWGenTxVADPR");
                    break;
                case "DummyFour":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � ����������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://youtu.be/wP8FgmW5z1M?si=p2R9KQry76AcA86V");
                    break;
                case "DummyFive":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � ����������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL(" https://youtu.be/32Ns2POEeh0?si=3RhvnrUVf-Fb0sDF");
                    break;
                case "DummySix":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � ��������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL(" https://youtu.be/RgWBJliHm4Q?si=j2mouXQrc7vUv_kr");
                    break;

                case "SignOne":
                    CanvasText.text = "�������  <color=red>�</color> ����� ��������� ������ ���������� � ���������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://president.gov.by/ru/belarus/regions/gomelskaya");
                    break;
                case "SignTwo":
                    CanvasText.text = "�������  <color=red>�</color> ����� ��������� ������ ���������� � ������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://president.gov.by/ru/belarus/regions/minskaya");
                    break;
                case "SignThree":
                    CanvasText.text = "�������  <color=red>�</color> ����� ��������� ������ ���������� � ��������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://president.gov.by/ru/belarus/regions/brestskaya");
                    break;
                case "SignFour":
                    CanvasText.text = "�������  <color=red>�</color> ����� ��������� ������ ���������� � ����������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://president.gov.by/ru/belarus/regions/mogilyovskaya");
                    break;
                case "SignFive":
                    CanvasText.text = "�������  <color=red>�</color> ����� ��������� ������ ���������� � ����������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://president.gov.by/ru/belarus/regions/grodnenskaya");
                    break;
                case "SignSix":
                    CanvasText.text = "�������  <color=red>�</color> ����� ��������� ������ ���������� � ��������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://president.gov.by/ru/belarus/regions/vitebskaya");
                    break;
                
            }
        }
    }
}
