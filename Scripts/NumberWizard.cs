﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] Text guessText;


    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();

        
    }

    // Update is called once per frame
    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
   
    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}

