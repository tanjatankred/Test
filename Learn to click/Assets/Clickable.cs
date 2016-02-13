using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour {

	public Animator animator;

	public bool playAnimation = false;

	void Start (){
		animator = GetComponent<Animator> ();
	
	}

	void OnMouseDown() { 
		playAnimation = !playAnimation;
		animator.SetBool ("Animate", playAnimation);
		Debug.Log ("uuuuh");
	
	}


}
