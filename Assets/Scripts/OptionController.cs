using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour {

    public Slider volumeSlider;
    public Slider difficultySlider;
    public LevelManager levelManager;

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.getDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
        musicManager.ChangeVolume(volumeSlider.value);
	}
    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.setDifficulty(difficultySlider.value);
        levelManager.LoadLevel("01a_Menu");
    }
    public void setDefaults()
    {
        volumeSlider.value = 0.8f;
        difficultySlider.value = 2f;
    }
}
