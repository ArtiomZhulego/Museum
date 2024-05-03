using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 originalPosition;
    public GameObject FilmCube2;

    private bool isFullScrean;
    void Start()
    {
        isFullScrean = true;
        originalPosition = new Vector3(-43.6f, 22.2f, 0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FilmCube2.transform.position = originalPosition;
            isFullScrean = false;
        }

        if (isFullScrean == false)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                FilmCube2.transform.position = new Vector3(-30.8f, 20.5f, 3.8f);
                isFullScrean = true;
            }
        }
    }
}
