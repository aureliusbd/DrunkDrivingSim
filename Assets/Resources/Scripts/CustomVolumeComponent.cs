using System;
using UnityEngine.Rendering;

[Serializable]
public class CustomVolumeComponent : VolumeComponent
{
    public ClampedFloatParameter horizontalBlur = new ClampedFloatParameter(0.005f, 0, 0.5f);
    public ClampedFloatParameter verticalBlur = new ClampedFloatParameter(0.005f, 0, 0.5f);
}