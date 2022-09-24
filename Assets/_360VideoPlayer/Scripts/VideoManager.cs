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
    
    private void OnEnable()
    {
        _videoPlayer.seekCompleted += OnComplete;
        _videoPlayer.prepareCompleted += OnComplete;
        _videoPlayer.loopPointReached += onLoop;
    }

    private void Awake()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
        
    }

    

    public void Start()
    {
        StartPrepare(index);
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

    public void SeekForward()
    {
        StartSeek(10.0f);
    }

    public void SeekBack()
    {
        StartSeek(-10.0f);
    }

    private void StartSeek(float seekAmount)
    {
        IsVideoReady = false;
        _videoPlayer.time += seekAmount;
    }

    public void NextVideo()
    {
        index++;
        if (index == VideoClips.Count)
            index = 0;
        
        StartPrepare(index);
    }

    public void PreviousVideo()
    {
        index--;
        if (index == -1)
            index = VideoClips.Count-1;
        
        StartPrepare(index);
    }

    private void StartPrepare(int clipIndex)
    {
        IsVideoReady = false;
        _videoPlayer.clip = VideoClips[clipIndex];
        _videoPlayer.Prepare();
    }

    private void OnComplete(VideoPlayer videoPlayer)
    {
        IsVideoReady = true;
        videoPlayer.Play();
    }

    private void onLoop(VideoPlayer videoPlayer)
    {
        NextVideo();
    }

    private void OnDisable()
    {
        _videoPlayer.seekCompleted -= OnComplete;
        _videoPlayer.prepareCompleted -= OnComplete;
        _videoPlayer.loopPointReached -= onLoop;
    }
}
