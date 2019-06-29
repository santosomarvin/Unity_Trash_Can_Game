using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 


public class TryAgainScript : MonoBehaviour
{
	// Start is called before the first frame update
	public Text introductionText;
	public Image introductionImage;
	public Button startButton;
	public Text startText;

	

	// Update is called once per frame
	void Update()
    {
		//Application.LoadLevel(Application.loadedLevel);
	}
    public void TaskOnClick()
	{
		PointTriggerScript.money = 0;
		int scene = SceneManager.GetActiveScene().buildIndex;
		//Time.timeScale = 1;
		SceneManager.LoadScene(scene, LoadSceneMode.Single);

		//introductionText.enabled = false;
		//introductionImage.enabled = false;
		//startButton.enabled = false;
		//startText.enabled = false;
		Debug.Log("introd  lkonkbkbkbkb uction text: "+introductionText.enabled);
	}
}
