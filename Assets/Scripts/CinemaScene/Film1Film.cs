using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Film1Film : MonoBehaviour
{
    public GameObject FilmCube;
    public Canvas FilmCanvas;
    public VideoPlayer videoPlayer;

    string videoUrl = "";

    private Vector3 targetPosition;
    protected bool isFullScrean = false;
    void Start()
    {
        FilmCube.SetActive(false);
        FilmCanvas.gameObject.SetActive(true); 
        targetPosition = new Vector3(-30.8f, 20.5f, 3.8f);
        Time.timeScale = 1f;
        isFullScrean = false;
    }
    

    void OnMouseDown()
    {
        
            PlayerPrefs.SetString("FilmName", "http://kinosotik.com/download/ironiya-sudqby-ili-s-legkim-parom-?original");
            videoUrl = PlayerPrefs.GetString("FilmName");

            videoPlayer.url = videoUrl;
            videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
            videoPlayer.EnableAudioTrack(0, true);
            videoPlayer.Prepare();

            FilmCanvas.gameObject.SetActive(false);
            FilmCube.SetActive(true);
            videoPlayer.Play();

            FilmCube.transform.position = targetPosition;
        isFullScrean = true;
    }    
}