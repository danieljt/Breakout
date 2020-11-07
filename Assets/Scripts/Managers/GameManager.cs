﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using StupidGirlGames.Patterns.Singleton;

namespace StupidGirlGames.BreakOut
{
    /// <summary>
    /// A game manager controls the flow of the game state and the save/load functionality. The game manager
    /// is a singleton as it needs to work from any scene
    /// </summary>
    public class GameManager : Singleton<GameManager>
    {
		private void Start()
		{
            DontDestroyOnLoad(this);
		}

        /// <summary>
        /// Load the next scene
        /// </summary>
        public void LoadNextLevel()
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}