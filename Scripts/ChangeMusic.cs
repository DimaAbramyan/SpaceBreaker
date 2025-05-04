using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMusic : MonoBehaviour
{
    [SerializeField]
    List<AudioClip> musicList;
    void Start()
    {
        
        AudioClip music = musicList[Random.Range(0, musicList.Count)];
        AudioSource MusicToChange = Camera.main.GetComponentInChildren<AudioSource>();
        if (music != null)
        {
            if (MusicToChange.clip != music || SceneManager.GetActiveScene().buildIndex > 4) 
            {
                MusicToChange.clip = music;
                MusicToChange.gameObject.SetActive(false);
                MusicToChange.gameObject.SetActive(true);
            }
        }

    }


}
