using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class AudioSettingsContinue : MonoBehaviour
{
    public Slider BGSlider, EFFECTSslider;
    public AudioSource[] soundeffects;
    public AudioSource backgroundmusic;
    private static readonly string backgroudpref = "bgpref";
    private static readonly string effectspref = "Epref";
    private void Awake()
    {
        backgroundmusic = GameObject.FindGameObjectWithTag("BGmusic").GetComponent<AudioSource>();
        for (int i = 0; i < soundeffects.Length; i++)
        {
            soundeffects[i] = GameObject.FindGameObjectWithTag((i + 1).ToString()).GetComponent<AudioSource>();
        }
        continueSettings();

        Debug.Log(PlayerPrefs.GetFloat(effectspref));

    }
    private void continueSettings()
    {
        BGSlider.value = PlayerPrefs.GetFloat(backgroudpref);
        EFFECTSslider.value = PlayerPrefs.GetFloat(effectspref);


        backgroundmusic.volume = BGSlider.value;
        for (int i = 0; i < soundeffects.Length; i++)
        {
            soundeffects[i].volume = EFFECTSslider.value;
        }
        

    }
}