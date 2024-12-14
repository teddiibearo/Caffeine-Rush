using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{
    public AudioMixer volume;

    public void SetVolume(float vol)
    {
        volume.SetFloat("vol", vol);
    }
}
