using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class AdjustBlurSettings : MonoBehaviour
{
    //[SerializeField] UniversalRendererData feature;

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

        //// Turn off Blur renderer feature when set to 0 to save on performance
        //if (drunkVal <= 0.0f)
        //{
        //    feature.rendererFeatures[0].SetActive(false);
        //}
        //else
        //{
        //    feature.rendererFeatures[0].SetActive(true);
        //}

        volume.profile.TryGet(out volumeComponent);

        volumeComponent.verticalBlur.value = 0.25f * drunkVal;
        volumeComponent.horizontalBlur.value = drunkVal;

        Debug.Log(drunkVal);
    }
}
