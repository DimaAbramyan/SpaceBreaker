using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    [SerializeField] Slider Slider;
    private AudioSource audioSource;
    private float musicVolume = 1f;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
    private void Update()
    {
   //     audioSource.volume = musicVolume;
        if(Slider.value != audioSource.volume)
        {
            audioSource.volume = Slider.value;
        }      
    }

   // public void SetVolume(float vol)
  //  {
  //      musicVolume = vol;
  //  }
}
