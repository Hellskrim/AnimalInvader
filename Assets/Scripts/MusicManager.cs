using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChange;
    private AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChange[level];
        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
