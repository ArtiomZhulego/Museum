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
                    CanvasText.text = "Нажмите  <color=red>Е</color> чтобы посмотреть видео о .......... области";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://youtu.be/ix48itrwChI");
                    break;
                case "DummyTwo":
                    CanvasText.text = "Нажмите  <color=red>Е</color> чтобы посмотреть видео о .......... области";
                    break;
                case "DummyThree":
                    CanvasText.text = "Нажмите  <color=red>Е</color> чтобы посмотреть видео о .......... области";
                    break;
                case "DummyFour":
                    CanvasText.text = "Нажмите  <color=red>Е</color> чтобы посмотреть видео о .......... области";
                    break;
                case "DummyFive":
                    CanvasText.text = "Нажмите  <color=red>Е</color> чтобы посмотреть видео о .......... области";
                    break;
                case "DummySix":
                    CanvasText.text = "Нажмите  <color=red>Е</color> чтобы посмотреть видео о .......... области";
                    break;
                case "SignOne":
                    CanvasText.text = "Нажмите  <color=red>Е</color> чтобы прочитать полную информацию о Брестской области";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://president.gov.by/ru/belarus/regions/brestskaya");
                    break;
                case "SignTwo":
                    CanvasText.text = "Нажмите  <color=red>Е</color> чтобы прочитать полную информацию о Витебской области";
                    if (Input.GetKeyDown(KeyCode.E))
                        Application.OpenURL("https://president.gov.by/ru/belarus/regions/vitebskaya");
                    break;
                default:
                    break;
            }
        }
    }
}
