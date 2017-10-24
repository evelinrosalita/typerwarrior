using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour {

	public void NewGameBtn(string newGameLevel1)
	{
		SceneManager.LoadScene (newGameLevel1);
	}

	public void ExitGameBtn()
	{
		Application.Quit ();
	}
}
