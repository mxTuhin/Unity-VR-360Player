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

        }

        if(OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {

        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {

        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {

        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {

        }
    }

    private void KeyboardInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
}
