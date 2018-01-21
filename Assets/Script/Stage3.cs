using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage3 : MonoBehaviour {

	public void Stage3Btn (string newGameStage3)
	{
		SceneManager.LoadScene (newGameStage3);
	}

}
