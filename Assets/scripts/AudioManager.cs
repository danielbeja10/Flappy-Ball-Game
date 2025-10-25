using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string backgroudpref = "bgpref";
    private static readonly string effectspref = "Epref";
    public Slider BGSlider, EFFECTSslider;
    public AudioSource backgroundmusic;
    public AudioSource[] soundeffects;
    private int firstplayint;
    private float backgroundfloat, soundeffectsfloat;
    public GameObject bgmute;
    public GameObject effectsmute;


    void Start()
    {
        backgroundmusic = GameObject.FindGameObjectWithTag("BGmusic").GetComponent<AudioSource>(); // Need to do this line beacouse of the DontDestroyOnLoad.
        for (int i = 0; i < soundeffects.Length; i++)
        {
            soundeffects[i] = GameObject.FindGameObjectWithTag((i + 1).ToString()).GetComponent<AudioSource>();
        }

        
        if (!PlayerPrefs.HasKey(effectspref) || !PlayerPrefs.HasKey(effectspref) )
        {
            backgroundfloat = 0.5f;
            soundeffectsfloat = 1f;
            BGSlider.value = backgroundfloat;
            EFFECTSslider.value = soundeffectsfloat;
            PlayerPrefs.SetFloat(backgroudpref, backgroundfloat);
            PlayerPrefs.SetFloat(effectspref, soundeffectsfloat);
        }
        else
        {
            backgroundfloat = PlayerPrefs.GetFloat(backgroudpref);
            BGSlider.value = backgroundfloat;
            soundeffectsfloat = PlayerPrefs.GetFloat(effectspref);
            EFFECTSslider.value = soundeffectsfloat;

        }

    }
    public void ChangeVolumeeffects()// Change the volume of the effect plus take care of the toggle as well.
    {
        for (int i = 0; i < soundeffects.Length; i++)
        {
            soundeffects[i].volume = EFFECTSslider.value;
        }
        if (EFFECTSslider.value == 0)
        {
            effectsmute.GetComponent<Toggle>().isOn = false;
        }
        else
        {
            effectsmute.GetComponent<Toggle>().isOn = true;
        }


    }

    public void ChangeVolumeBG()// Change the volume of the BG plus take care of the toggle as well.
    {
        backgroundmusic.volume = BGSlider.value;
        if (BGSlider.value != 0f)
        {
            bgmute.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            bgmute.GetComponent<Toggle>().isOn = false;
        }
       

    }
    public void SaveStats() // Save the data from the player.
    {
        PlayerPrefs.SetFloat(backgroudpref, BGSlider.value);
        PlayerPrefs.SetFloat(effectspref, EFFECTSslider.value);
        Debug.Log("what save in key:" + PlayerPrefs.GetFloat(effectspref));

    }
    public void toggleffects()
    {
        if (effectsmute.GetComponent<Toggle>().isOn == false)
        {
            EFFECTSslider.value = 0f;
        }
       if(effectsmute.GetComponent<Toggle>().isOn && EFFECTSslider.value == 0f)
        {
            EFFECTSslider.value = 0.5f;
        }
    }
    public void togglebg()
    {
        if(bgmute.GetComponent<Toggle>().isOn == false)
        {
            BGSlider.value = 0f;
        }
        if (bgmute.GetComponent<Toggle>().isOn && BGSlider.value == 0f)
        {
            BGSlider.value = 0.5f;
        }
    }
    public void resetTodefault()
    {
        BGSlider.value = 0.5f;
        EFFECTSslider.value = 1f;

    }


} 
