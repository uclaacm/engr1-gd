using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;
using UnityEngine.Audio;

public class SliderController : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI sliderText = null;
    private float sliderScaler = 100f;
    public void UseSlider(float val)
    {
        float sliderVal = val * sliderScaler;
        sliderText.text = sliderVal.ToString("0");
        audioMixer.SetFloat("MusicVolume", sliderVal);
    }
    
}
