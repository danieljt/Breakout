﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace StupidGirlGames.BreakOut
{
    /// <summary>
    /// Select the given gameobject on enable. This component will only select something
	/// if the scene has an eventsystem.
    /// </summary>
    public class ButtonSelectOnEnable : MonoBehaviour
    {
		public GameObject firstSelected;

		private void OnEnable()
		{
			if (EventSystem.current != null && firstSelected != null)
			{
				EventSystem.current.SetSelectedGameObject(firstSelected);
				Button button = firstSelected.GetComponent<Button>();
				if(button)
				{
					button.OnSelect(null);
				}
			}
		}
	}
}
