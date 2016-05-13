using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	private AudioSource audioSource;
	public GameObject clown;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent <AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Scare")){
			audioSource.Play ();

		}



	}

}
