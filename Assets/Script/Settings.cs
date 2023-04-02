using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    [SerializeField] private bool isFullScreen;
    [SerializeField] private AudioMixer track;
    Resolution[] rsl;
    List<string> resolutions;
    public TMP_Dropdown dropdown;
    public void Awake()
    {
        resolutions = new List<string>();
        rsl = Screen.resolutions;
        foreach (var i in rsl)
        {
            resolutions.Add(i.width + "x" + i.height);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(resolutions);
    }
    public void isFullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen= isFullScreen;
    }
    public void AudioVolume(float sliderValue)
    {
        track.SetFloat("MasterVolume", sliderValue);
    }
    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }
    public void Resolution(int r)
    {
        Screen.SetResolution(rsl[r].width, rsl[r].height, isFullScreen);
    }
}
