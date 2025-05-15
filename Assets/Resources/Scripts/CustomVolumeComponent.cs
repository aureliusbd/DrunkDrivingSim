using System;
using UnityEngine.Rendering;

[Serializable]
public class CustomVolumeComponent : VolumeComponent
{
    public ClampedFloatParameter horizontalBlur = new ClampedFloatParameter(0.0f, 0.0f, 0.20f);
    public ClampedFloatParameter verticalBlur = new ClampedFloatParameter(0.0f, 0.0f, 0.20f);
}