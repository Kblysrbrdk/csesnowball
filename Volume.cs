using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Volume : MonoBehaviour {
	public string backMenuScene;


	public void backToMenu()
	{
		SceneManager.LoadScene(backMenuScene);


	}
}