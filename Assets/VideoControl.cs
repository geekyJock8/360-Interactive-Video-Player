using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    public GameObject canvas;
    public GameObject player;
    public GameObject asianMagic;
    public GameObject europeanMagic;
    private UnityEngine.Video.VideoPlayer videoPlayer;

    private bool videoPaused;
    private int option;

    void Start()
    {
        option = 0;
        videoPaused = false;
        videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    void Update()
    {
        //print(videoPlayer.time);
        if(option == 1 && videoPlayer.time > 512)
        {
            Magic();
        }
        else if(option == 2 && videoPlayer.time > 644)
        {
            Magic();
        }
    }

    public void PlayPauseVideo()
    {
        if(videoPaused)
        {
            videoPaused = false;
            videoPlayer.Play();
        }
        else
        {
            videoPaused = true;
            videoPlayer.Pause();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void OptionAsia()
    {
        option = 1;
        print(option);
        canvas.SetActive(false);
        videoPlayer.url = "https://www.dropbox.com/s/w7qgqk8eee1nn9r/asia_injected.mp4?dl=1";
        videoPlayer.Play();
    }

    public void OptionEurope()
    {
        option = 2;
        print(option);
        canvas.SetActive(false);
        videoPlayer.url = "https://www.dropbox.com/s/mrljd91dlscve4y/europe_injected.mp4?dl=1";
        videoPlayer.Play();
    }

    private void Magic()
    {
        if(option == 1)
        {
            asianMagic.SetActive(true);
            player.transform.position = asianMagic.transform.position;
        }
        else if(option == 2)
        {
            europeanMagic.SetActive(true);
            player.transform.position = europeanMagic.transform.position;
        }
    }
}