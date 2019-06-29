using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorScript : MonoBehaviour
{
	public Image endBackground;
	public Text endText;
	public Button tryAgainButton;
	public Text tryAgainText;
	public Image tryAgainImage;
	public AudioClip musicClip;
	public AudioSource musicSource;
	// Start is called before the first frame update
	void Start()
	{
		musicSource.clip = musicClip;

	}

	// Update is called once per frame
	void Update()
	{
        
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Trash")
		{
			//instantiate hud
			endBackground.enabled = true;
			endText.enabled = true;
			tryAgainButton.enabled = true;
			tryAgainText.enabled = true;
			tryAgainImage.enabled = true;
			Time.timeScale = 0;

		}
        if(other.tag == "Book")
		{
			musicSource.Play();
		}
	}
}
