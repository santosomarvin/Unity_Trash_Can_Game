using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyScript : MonoBehaviour
{
	public AudioClip musicClip;
	public AudioSource musicSource;
	Animator animator;

    // Start is called before the first frame update
    void Start()
    {
		animator = GetComponent<Animator>();
		musicSource.clip = musicClip;

	}

	// Update is called once per frame
	void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Book")
		{
			Destroy(other.gameObject);
			PointTriggerScript.money += 200;
			//animator.CrossFade("jump-up", 0.1f);
			animator.SetTrigger("Jump");
			musicSource.Play();

		}
	}
}
