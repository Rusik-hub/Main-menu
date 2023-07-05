using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] private AudioSource _aboutAuthorsMusic;
    [SerializeField] private AudioSource _gameMusic;
    [SerializeField] private List<TMP_Text> _textsOnScene;

    private void Start()
    {
        UpdateSettings();
        _gameMusic.Play();
    }

    public void UpdateSettings()
    {
        _gameMusic.volume = SettingsSaver.SoundVolume;

        for (int i = 0; i < _textsOnScene.Count; i++)
        {
            _textsOnScene[i].color = SettingsSaver.TextColor;
        }
    }

    public void OpenAboutAuthorsWindow()
    {
        StartCoroutine(PlayAboutAuthorsMusic());
    }

    private IEnumerator PlayAboutAuthorsMusic()
    {
        _gameMusic.Stop();
        _aboutAuthorsMusic.Play();

        yield return new WaitForSeconds(7.5f);
        _gameMusic.Play();
    }
}
