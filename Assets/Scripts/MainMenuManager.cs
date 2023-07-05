using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Slider _volume;
    [SerializeField] private Slider _textColor;
    [SerializeField] private AudioSource _authorsSound;
    [SerializeField] private AudioSource _gameSound;
    [SerializeField] private GameObject _settingsWindow;
    [SerializeField] private GameObject _buttonsParent;

    private void Start()
    {
        CloseSettings();

        _gameSound.Play();
    }

    public void StartGame()
    {
        Debug.Log("Загрузка уровня.");
    }

    public void OpenSettings()
    {
        _settingsWindow.SetActive(true);
        _buttonsParent.SetActive(false);
    }

    public void CloseSettings()
    {
        _settingsWindow.SetActive(false);
        _buttonsParent.SetActive(true);
    }

    public void SetVolumeValue(float value)
    {
        SettingsSaver.SoundVolume = value;
    }

    public void SetTextColor(float value)
    {
        SettingsSaver.TextColor = value;
    }

    public void OpenAboutAuthorsWindow()
    {
        _gameSound.Stop();
        _authorsSound.Play();
    }

    public void Exit()
    {
        Debug.Log("Выход.");
        Application.Quit();
    }
}
