using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundAudio : MonoBehaviour
{
    public new AudioSource audio;
    void Update()
    {
    }
    public void StopMusic()
    {
        audio.Stop();
    }
}
