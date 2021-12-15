using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioDJMaster : MonoBehaviour
{
    AudioSource _audioSource;
    protected AudioMixer __audioMixer;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        __audioMixer = _audioSource.outputAudioMixerGroup.audioMixer;
        _audioSource.volume = .5f;
    }
    public void SetVolume(float volume)
    {
        // convert volume to -80 to 20 db
        // using a slider from 0 to 1 -> it's minRange set it to 0.0001f
        volume = Mathf.Log10(volume) * 20;
        __audioMixer.SetFloat("Volume", volume);
    }

    public void SetPitch(float pitch)
    {
        pitch = Utils.mapRange(pitch, 0, 1, -1, 2);
        _audioSource.pitch = pitch;
    }

    public void SetStereo(float stereo)
    {
        stereo = Utils.mapRange(stereo, 0, 1, -1, 1);
        _audioSource.panStereo = stereo;
    }
}
