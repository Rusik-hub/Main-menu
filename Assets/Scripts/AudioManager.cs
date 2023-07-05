using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    private AudioSource _gameMusic;

    private void Start()
    {
        _gameMusic = GetComponent<AudioSource>();

        UpdateSettings();
    }

    public void UpdateSettings()
    {
        _gameMusic.volume = SettingsSaver.SoundVolume;
    }
}
