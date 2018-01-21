using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2 : MonoBehaviour {

	public void Stage2Btn (string newGameStage2)
	{
		SceneManager.LoadScene (newGameStage2);
	}
}
