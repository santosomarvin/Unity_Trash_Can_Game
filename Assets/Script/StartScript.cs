using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
	// Start is called before the first frame update
	public Text introductionText;
	public Image introductionImage;
	public Button startButton;
	public Text startText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void TaskOnClick()
	{
		introductionText.enabled = false;
		introductionImage.enabled = false;
		startButton.enabled = false;
		startText.enabled = false;
		Time.timeScale = 1;
	}
}
