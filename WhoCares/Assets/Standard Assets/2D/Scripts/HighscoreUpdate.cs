﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace UnityStandardAssets._2D
{
    public class HighscoreUpdate : MonoBehaviour
    {
        Highscores hs;

        public Text fieldhs;
        public Text fieldths;

        // Use this for initialization
        void Start()
        {
            hs = GameObject.Find("Scores").GetComponent("Highscores") as Highscores;
        }

        // Update is called once per frame
        void Update()
        {
            fieldhs.text = "Your score was: " + hs.Highscore;
            fieldths.text = "The total highscore was: " + hs.TotalHighscore;
        }
    }
}
