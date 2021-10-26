using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour {

    public AudioMixer Master;
    public Slider SliderVolume;

    void Start()
    {
        SliderVolume.value = PlayerPrefs.GetFloat("MasterVolume", 0.5f);
    }
    public void SetLevel (float sliderValue)
    {
	Master.SetFloat("MasterVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MasterVolume", sliderValue);
    }
}