using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayerPref : MonoBehaviour
{
    public GameObject messege;
    public GameObject sllider1, sllider2;
    public GameObject backbutton;
    public GameObject deletesettingbutton;
    public AudioManager am;
    public void yesbutton()
    {
        PlayerPrefs.DeleteKey("highScore");
        am.resetTodefault();
        messege.SetActive(false);
        sllider1.SetActive(true);
        sllider2.SetActive(true);
        backbutton.SetActive(true);
        deletesettingbutton.SetActive(true);
    }
    public void openareusure()
    {
        messege.SetActive(true);
        sllider1.SetActive(false);
        sllider2.SetActive(false);
        backbutton.SetActive(false);
        deletesettingbutton.SetActive(false);

    }
    public void nobutoon()
    {
        messege.SetActive(false);
        sllider1.SetActive(true);
        sllider2.SetActive(true);
        backbutton.SetActive(true);
        deletesettingbutton.SetActive(true);
    }
}
