using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    AudioSource MusicToChange;
    public void StopMusic()
    {
        AudioSource MusicToChange = Camera.main.GetComponentInChildren<AudioSource>();
        MusicToChange.Pause();
    }
    public void StartMusic()
    {
        AudioSource MusicToChange = Camera.main.GetComponentInChildren<AudioSource>();
        MusicToChange.UnPause();
    }
}
