using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDJ : MonoBehaviour
{
    public void SetVolume(float v)
    {
        AudioSource[] audioSources = GetComponentsInChildren<AudioSource>();
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume = v;
            audioSource.outputAudioMixerGroup.audioMixer.SetFloat("Volume", v);
        }
    }
}
