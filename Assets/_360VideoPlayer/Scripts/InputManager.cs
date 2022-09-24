using System;
using UnityEngine;
using UnityEngine.Video;

public class InputManager : MonoBehaviour
{
    public VideoManager VideoManager = null;

    private void Update()
    {
        if(!VideoManager.IsVideoReady)
            return;
        
        OculusInput();
        KeyboardInput();
    }

    private void OculusInput()
    {
        if(OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.All))
        {
            VideoManager.PauseToggle();
        }

        if(OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            VideoManager.PreviousVideo();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            VideoManager.NextVideo();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            VideoManager.SeekBack();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            VideoManager.SeekForward();
        }
    }

    private void KeyboardInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            VideoManager.PauseToggle();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            VideoManager.PreviousVideo();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            VideoManager.NextVideo();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            VideoManager.SeekBack();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {  
            VideoManager.SeekForward();
        }
    }
}
