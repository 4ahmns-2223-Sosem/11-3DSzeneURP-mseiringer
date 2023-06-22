using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class Videoplayer : MonoBehaviour
{
    public Button button1;
    public VideoPlayer videoPlayer;
    void Start()
    {
        button1.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Stop();
        }
        else
        {
            videoPlayer.Play();
        }
    }

    void Update()
    {
        
    }
}

