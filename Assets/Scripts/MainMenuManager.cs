using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Slider _volume;
    [SerializeField] private Slider _textColor;
    [SerializeField] private GameObject _settingsWindow;
    [SerializeField] private GameObject _buttonsParent;

    private Color _startColor = new Color(0, 0, 0, 1);
    private Color _endColor = new Color(0.5f, 1, 0.5f, 1);

    private void Start()
    {
        CloseSettings();
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
        SettingsSaver.TextColor = Color.Lerp(_startColor, _endColor, value);
    }

    public void Exit()
    {
        Debug.Log("Выход.");
        Application.Quit();
    }
}
