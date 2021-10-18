using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetLevel(float sliderValue)
    {
        audioMixer.SetFloat("volume", Mathf.Log10(sliderValue) * 20);
    }

}
