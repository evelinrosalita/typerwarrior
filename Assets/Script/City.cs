using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class City : MonoBehaviour {

	public void SkipBtn(string newGameHomeCity)
	{
		SceneManager.LoadScene (newGameHomeCity);
	}
		
}
