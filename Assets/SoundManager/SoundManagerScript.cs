using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip flaksSound, poengSound, birdhitttSound;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {

		//legg lydane i ein "resources" mappe

		flaksSound = Resources.Load<AudioClip> ("flaks");
		poengSound = Resources.Load<AudioClip> ("poeng");
		birdhitttSound = Resources.Load<AudioClip> ("birdHittt");

		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	}
	// her er alle lydene, så eg kan hente dei med denne settningen
	// SoundManagerScript.PlaySound ("poeng");
	public static void PlaySound (string clip)
	{
		switch (clip) {
		case "flaks":
			audioSrc.PlayOneShot (flaksSound);
			audioSrc.pitch = (Random.Range (1f, 1.4f));
			break;
		case "poeng":
			audioSrc.PlayOneShot (poengSound);
			break;
		case "birdHittt":
			audioSrc.PlayOneShot (birdhitttSound);
			audioSrc.pitch = (Random.Range (0.8f, 1f));

			break;
		
		}
	}
}
