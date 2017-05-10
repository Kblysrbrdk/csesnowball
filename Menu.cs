using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public string mainGameScene;
	public string optionsScene;

	public void StartGame()
    {
        SceneManager.LoadScene(mainGameScene);
    }
	public void Options()
	{
		SceneManager.LoadScene(optionsScene);
	}
    public void QuitGame()
    {
        Application.Quit();
    }
}
