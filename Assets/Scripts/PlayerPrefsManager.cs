﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFF_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";

    public static void SetMasterVolume(float volume)
    {
        if (volume >= 0f && volume <= 1f)
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void UnlockLevel(int level)
    {
        if(level <= SceneManager.sceneCount - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
        }
    }
    public static bool isLevelUnlocked(int level)
    {
        int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        bool isLevelUnlocked = (levelValue == 1);
        if (level <= SceneManager.sceneCount - 1)
            return isLevelUnlocked;
        else
            return false;
    }

    public static void setDifficulty(float diff)
    {
        if (diff >= 1f && diff <= 3f)
            PlayerPrefs.SetFloat(DIFF_KEY, diff);
    }
    public static float getDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFF_KEY);
    }
	
}
