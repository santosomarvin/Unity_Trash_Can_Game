using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointTriggerScript : MonoBehaviour
{
    public static int money;
	public Text scoreText;
	//public Text finalScore;
	public ParticleSystem particleSystem;
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
		scoreText.text = "Money: " + money;
		//finalScore.text = "  Money: " + money;

	}

	void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Trash")
		{
			money += 100;
			Destroy(other.gameObject);
			Instantiate(particleSystem, this.transform.position + new Vector3(0,1.5f,0), this.transform.rotation);
			musicSource.Play();
		} else if(other.tag == "Book")
		{
			money -= 300;                                                
			Destroy(other.gameObject);
		}
	}
}
