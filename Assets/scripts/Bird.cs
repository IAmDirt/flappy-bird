using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
	public float upForce = 200f;

	private bool isDead = false;
	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		//vist bird er lever kan han fly
		if (isDead == false) {
			if (Input.GetMouseButtonDown (0)) 
			{
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce (new Vector2 (0, upForce));
				anim.SetTrigger ("Flap");

				SoundManagerScript.PlaySound ("flaks");

			}
		}
	}
	//vist bird er død, kan han ikkje fly
	void OnCollisionEnter2D ()
	{
		SoundManagerScript.PlaySound ("birdHittt");
		rb2d.velocity = Vector2.zero;
		isDead = true;
		anim.SetTrigger ("Die");
		GameControl.instance.BirdDied ();

	}
}

