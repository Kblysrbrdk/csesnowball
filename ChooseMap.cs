using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMap : MonoBehaviour {
	public string easyMapScene;
	public string difficultMapScene;
	public string backMenuScene;

	public void EasyMap()
	{
		SceneManager.LoadScene(easyMapScene);


	}
	public void DifficultMap()
	{
		
		SceneManager.LoadScene(difficultMapScene);

	}
	public void BackMenu()
	{

		SceneManager.LoadScene(backMenuScene);

	}

}
