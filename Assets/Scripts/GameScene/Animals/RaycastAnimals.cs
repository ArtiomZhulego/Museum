using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaycastAnimals : MonoBehaviour
{
    public TMP_Text CanvasText;
    public Animator AnimalAnimator;

    public AudioSource Player;

    public AudioClip ������;
    public AudioClip �����;
    public AudioClip �������;
    public AudioClip ������;
    public AudioClip �����;
    public AudioClip ������;

    private void Awake()
    {
        Player.Stop();
    }

    void Update()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 40);

        if (hit.collider == null) CanvasText.text = String.Empty;
        else
        {
            switch (hit.collider.gameObject.tag)
            {
                case "Rabbit":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "H������ <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "H������ <color=green>�</color> ��� ������������� �������� � ����������� �������";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Player.isPlaying)
                        {
                            if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                        }
                        else
                        {
                            if (Input.GetKeyDown(KeyCode.E))
                            {
                                Player.clip = ������;
                                Player.Play();
                            }
                        }
                    }
                    
                    break;
                case "Deer":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "������� <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "������� <color=green>�</color> ��� ������������� �������� � ��������� �������";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Player.isPlaying)
                        {
                            if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                        }
                        else
                        {
                            if (Input.GetKeyDown(KeyCode.E))
                            {
                                    Player.clip = �����;
                                    Player.Play();
                            }
                        }
                    }

                    break;
                case "Moose":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "H������ <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "H������ <color=green>�</color> ��� ������������� �������� � ���������� �������";

                    if (Input.GetKeyDown(KeyCode.E)) 
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Player.isPlaying)
                        {
                            if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                        }
                        else
                        {
                            if (Input.GetKeyDown(KeyCode.E))
                            {
                                Player.clip = ������;
                                Player.Play();
                            }
                        }
                    }

                    break;
                case "Bear":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "H������ <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "H������ <color=green>�</color> ��� ������������� �������� � ���������� �������";

                    if (Input.GetKeyDown(KeyCode.E)) 
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Player.isPlaying)
                        {
                            if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                        }
                        else
                        {
                            if (Input.GetKeyDown(KeyCode.E))
                            {
                                Player.clip = ������;
                                Player.Play();
                            }
                        }
                    }

                    break;

                case "Fox":
                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "H������ <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "H������ <color=green>�</color> ��� ������������� �������� � ������� �������";

                    if (Input.GetKeyDown(KeyCode.E)) 
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Input.GetKeyDown(KeyCode.E))
                        {
                           
                            if (Player.isPlaying)
                            {
                                if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                            }
                            else
                            {
                                if (Input.GetKeyDown(KeyCode.E))
                                {
                                    Player.clip = �����;
                                    Player.Play();
                                }
                            }
                        }
                    }

                    break;

                case "Bunny":
                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "H������ <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "H������ <color=green>�</color> ��� ������������� �������� � ������� �������";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            if (Player.isPlaying)
                            {
                                if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                            }
                            else
                            {
                                if (Input.GetKeyDown(KeyCode.E))
                                {
                                    Player.clip = �����;
                                    Player.Play();
                                }
                            }
                        }
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
