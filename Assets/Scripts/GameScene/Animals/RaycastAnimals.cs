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

    public AudioClip Гомель;
    public AudioClip Брест;
    public AudioClip Витебск;
    public AudioClip Могилёв;
    public AudioClip Минск;
    public AudioClip Гродно;

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

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "Hажмите <color=red>Е</color> для прекращения прослушивания рассказа";
                    else CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания рассказа о Гродненской области";

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
                                Player.clip = Гродно;
                                Player.Play();
                            }
                        }
                    }

                    break;
                case "Deer":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "Нажмите <color=red>Е</color> для прекращения прослушивания рассказа";
                    else CanvasText.text = "Нажмите <color=green>Е</color> для прослушивания рассказа о Брестской области";

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
                                Player.clip = Брест;
                                Player.Play();
                            }
                        }
                    }

                    break;
                case "Moose":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "Hажмите <color=red>Е</color> для прекращения прослушивания рассказа";
                    else CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания рассказа о Гомельской области";

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
                                Player.clip = Гомель;
                                Player.Play();
                            }
                        }
                    }

                    break;
                case "Bear":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "Hажмите <color=red>Е</color> для прекращения прослушивания рассказа";
                    else CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания рассказа о Могилёвской области";

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
                                Player.clip = Могилёв;
                                Player.Play();
                            }
                        }
                    }

                    break;

                case "Fox":
                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "Hажмите <color=red>Е</color> для прекращения прослушивания рассказа";
                    else CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания рассказа о Минской области";

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
                                    Player.clip = Минск;
                                    Player.Play();
                                }
                            }
                        }
                    }

                    break;

                case "Bunny":
                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "Hажмите <color=red>Е</color> для прекращения прослушивания рассказа";
                    else CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания рассказа о Витебской области";

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
                                    Player.clip = Витебск;
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
