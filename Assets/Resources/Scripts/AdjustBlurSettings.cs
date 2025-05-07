using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class AdjustBlurSettings : MonoBehaviour
{
    public Slider blurSlider;
    public Volume volume;
    private CustomVolumeComponent volumeComponent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        blurSlider.onValueChanged.AddListener(delegate { AdjustBlur(); });
    }


    public void AdjustBlur()
    {
        float drunkVal = blurSlider.value;

        volume.profile.TryGet(out volumeComponent);

        volumeComponent.verticalBlur.value = 0.25f * drunkVal;
        volumeComponent.horizontalBlur.value = drunkVal;

        Debug.Log(drunkVal);
    }
}
