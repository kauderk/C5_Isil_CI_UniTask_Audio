using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DualAudioDJ : AudioDJMaster
{
    public AudioSource audioSourceRight;
    public AudioSource audioSourceLeft;
    Slider _slider;
    float unityVolume(float v) => Mathf.Log10(v) * 20;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        if (!__audioMixer || !_slider) Debug.LogError("AudioDJMaster: AudioMixer is not set");
    }

    public void DualAttenuation(float volume)
    {


        // works
        //audioSourceRight.volume = volume;
        //audioSourceLeft.volume = ;

        // // kinda works
        var min = _slider.minValue;
        var max = _slider.maxValue;
        var volume2 = unityVolume(Utils.mapRange(volume, min, max, max, min));

        __audioMixer.SetFloat("RightVolume", unityVolume(volume));
        __audioMixer.SetFloat("LeftVolume", volume2);
    }
}
