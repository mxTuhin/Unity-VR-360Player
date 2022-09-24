using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public List<VideoClip> VideoClips = null;

    private bool isPaused = false;

    public bool IsPaused
    {
        get
        {
            return isPaused;
        }
        private set
        {
            isPaused = value;
            // Pause Event
        }
    }

    private bool isVideoReady = false;

    public bool IsVideoReady
    {
        get
        {
            return isVideoReady;
        }

        private set
        {
            isVideoReady = value;
        }
    }

    private int index = 0;
    private VideoPlayer _videoPlayer = null;

    private void Awake()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
    }

    public void PauseToggle()
    {
        IsPaused = !_videoPlayer.isPaused;
        if (IsPaused)
        {
            _videoPlayer.Pause();
        }
        else
        {
            _videoPlayer.Play();
        }
    }
}
