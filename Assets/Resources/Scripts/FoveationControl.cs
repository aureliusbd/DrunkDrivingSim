using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class FoveationControl : MonoBehaviour
{
    XRDisplaySubsystem xrDisplaySubsystem;
    public float strength = 1.0f;

    void Start()
    {
        // Find the XR display subsystem
        var xrDisplaySubsystems = new List<XRDisplaySubsystem>();
        SubsystemManager.GetSubsystems<XRDisplaySubsystem>(xrDisplaySubsystems);

        if (xrDisplaySubsystems.Count < 1)
        {
            Debug.LogError("No XR display subsystems found.");
            return;
        }
        foreach (var subsystem in xrDisplaySubsystems)
        {
            if (subsystem.running)
            {
                xrDisplaySubsystem = subsystem;
                break;
            }
        }
        //xrDisplaySubsystem.foveatedRenderingFlags = XRDisplaySubsystem.FoveatedRenderingFlags.GazeAllowed;
        SetFRLevel();
    }

    public void SetFRLevel()
    {
        xrDisplaySubsystem.foveatedRenderingLevel = strength;
    }
}
