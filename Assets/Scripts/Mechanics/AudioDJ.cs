using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class AudioDJ : MonoBehaviour
{
    AudioSource _audioSource;
    AudioMixer _audioMixer;
    float _crrTime = 0;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioMixer = _audioSource.outputAudioMixerGroup.audioMixer;
        _audioSource.volume = .5f;
    }

    public void SetVolume(float volume)
    {
        //_audioMixer.SetFloat("Volume", volume);
        _audioSource.volume = volume;
    }

    public void Mute() => _audioSource.Pause();
    public void Unmute() => _audioSource.UnPause();
    public void Pause()
    {
        SetCurrentTime();
        _audioSource.Stop();
    }
    public void Play()
    {
        _audioSource.time = _crrTime;
        _audioSource.Play();
    }
    void SetCurrentTime() => _crrTime = _audioSource.time;


    public void TooglePlay()
    {
        if (_audioSource.isPlaying)
            Pause();
        else
            Play();
    }

    public void ChangeVolume(float volume)
    {
        volume = Mathf.Clamp(volume, 0, 1);
        _audioSource.volume = volume;
    }

    public void ApplyPitch(float pitch)
    {
        pitch = Utils.mapRange(pitch, 0, 1, -1, 2);
        _audioSource.pitch = pitch;
    }

    public void ApplyStereo(float stereo)
    {
        stereo = Utils.mapRange(stereo, 0, 1, -1, 1);
        _audioSource.panStereo = stereo;
    }
}
