using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DualAudioDJ : AudioDJMaster
{
    public AudioSource audioSourceRight;
    public AudioSource audioSourceLeft;
    Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        if (!__audioMixer)
            __audioMixer = GetComponent<AudioSource>().outputAudioMixerGroup.audioMixer;
        if (!__audioMixer)
            Debug.LogWarning("AudioDJMaster: AudioMixer set automatically...", gameObject);
    }

    public void DualAttenuation(float volume)
    {
        float unityVolume(float v) => Mathf.Log10(v) * 20;

        // // kinda works
        var min = _slider.minValue;
        var max = _slider.maxValue;
        var volume2 = unityVolume(Utils.mapRange(volume, min, max, max, min));

        __audioMixer.SetFloat("RightVolume", volume2);
        __audioMixer.SetFloat("LeftVolume", unityVolume(volume));
    }
}
