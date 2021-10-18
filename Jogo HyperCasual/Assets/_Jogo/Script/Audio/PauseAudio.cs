using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{
    void Start()
    {
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
    void Update()
    {

    }
}
