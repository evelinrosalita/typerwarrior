using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeCity : MonoBehaviour {

	public void RestartBtn (string newGameMainMenu)
	{
		SceneManager.LoadScene (newGameMainMenu);
	}

	public void ExitGameBtn()
	{
		Application.Quit ();
	}
}
