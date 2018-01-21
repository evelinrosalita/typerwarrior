using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1 : MonoBehaviour {

	public void Stage1Btn (string newGameStage1)
	{
		SceneManager.LoadScene (newGameStage1);
	}
		
}
