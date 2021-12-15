using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildSource : MonoBehaviour
{
    public void ThisChildIsPlaying()
    {
        SendMessageUpwards("ChildIsPlaying", GetComponent<AudioSource>());
    }
}
