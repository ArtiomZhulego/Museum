using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

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
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � .......... �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://youtu.be/ix48itrwChI");
                    break;
                case "DummyTwo":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � .......... �������";
                    break;
                case "DummyThree":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � .......... �������";
                    break;
                case "DummyFour":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � .......... �������";
                    break;
                case "DummyFive":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � .......... �������";
                    break;
                case "DummySix":
                    CanvasText.text = "�������  <color=red>�</color> ����� ���������� ����� � .......... �������";
                    break;
                case "SignOne":
                    CanvasText.text = "�������  <color=red>�</color> ����� ��������� ������ ���������� � ��������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://president.gov.by/ru/belarus/regions/brestskaya");
                    break;
                case "SignTwo":
                    CanvasText.text = "�������  <color=red>�</color> ����� ��������� ������ ���������� � ��������� �������";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://president.gov.by/ru/belarus/regions/vitebskaya");
                    break;
                default:
                    break;
            }
        }
    }
}
