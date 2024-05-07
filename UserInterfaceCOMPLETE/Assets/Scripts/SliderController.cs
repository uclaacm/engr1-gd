using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro; 

public class SliderController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI sliderText = null;
    private float sliderScaler = 100f;
    public void UseSlider(float val)
    {
        float sliderVal = val * sliderScaler;
        sliderText.text = sliderVal.ToString("0");
    }
}
