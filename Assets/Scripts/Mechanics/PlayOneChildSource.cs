using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOneChildSource : MonoBehaviour
{
    AudioSource childPlaying;
    public void AllowOneSoundMax()
    {
        AudioSource[] sources = GetComponentsInChildren<AudioSource>();
        foreach (AudioSource source in sources)
        {
            if (childPlaying == source && childPlaying.isPlaying)
                continue;
            source.mute = true;
            source.Stop();
            source.time = 0;
            source.mute = true;
        }
    }

    public void ChildIsPlaying(AudioSource source)
    {
        childPlaying = source;
    }
}
