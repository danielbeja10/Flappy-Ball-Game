using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System;
using TMPro;

public class addScore : MonoBehaviour
{
    public int playerscore = 0;
    public Text scoreTEXT;
    public GameObject gameoverscreen;
    public TextMeshProUGUI newhighscoretext;
    public TextMeshProUGUI currentscore;
    public AudioSource gameoversound;
    public PipesMovement A;
    public float movespeed = 5;
    public float difficultyLevel = 10;// The lower the number, the harder the game.//
    public MainMenu Startt;
    public nnnnnn ballalive;

    public void addscore(int scoreToAdd)
    {
         A = GameObject.FindGameObjectWithTag("pipesparty").GetComponent<PipesMovement>();
        
        levelup();
        playerscore = playerscore + scoreToAdd;
        scoreTEXT.text = playerscore.ToString();
    }
   
    public void gameover()
    {
        if(highScoreMethod())
        {
            newhighscoretext.GetComponent<TextMeshProUGUI>().text = "NEW HIGH SCORE!:" + " " + PlayerPrefs.GetInt("highScore").ToString();
            currentscore.GetComponent<TextMeshProUGUI>().text = "SCORE:" + playerscore.ToString();
        }
        else
        {
            newhighscoretext.GetComponent<TextMeshProUGUI>().text = "HIGH SCORE:"+" " + PlayerPrefs.GetInt("highScore").ToString();
            newhighscoretext.GetComponent<TextMeshProUGUI>().color = Color.black;
            currentscore.GetComponent<TextMeshProUGUI>().text = "SCORE:"+ " " + playerscore.ToString();
        }
      
       
        gameoversound = GameObject.FindGameObjectWithTag("2").GetComponent<AudioSource>();
        gameoversound.Play();
        gameoverscreen.SetActive(true);

    }
    public void levelup()
    {
        if (playerscore % difficultyLevel != 0)
        {
            movespeed=movespeed+1;
        }
    }
    public bool highScoreMethod()
    {
        if(PlayerPrefs.HasKey("highScore") == false)
        {
            PlayerPrefs.SetInt("highScore", playerscore);
           
        }
        if (playerscore > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", playerscore);
            return true;
        }
        else
            return false;
        
    }
}
