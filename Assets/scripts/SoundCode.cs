using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundCode : MonoBehaviour {
	
	public AudioClip gameMusic1;
	public AudioClip gameMusic2;
	public AudioClip gameMusic3;
	public AudioClip gameMusic4;
	
	List<AudioClip> gameMusic=new List<AudioClip>();
	

	
	// Use this for initialization
	void Start () {
		gameMusic.Add (gameMusic1);
		gameMusic.Add(gameMusic2);
		gameMusic.Add(gameMusic3);
		gameMusic.Add(gameMusic4);
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!GetComponent<AudioSource>().isPlaying) {
			GetComponent<AudioSource>().clip=gameMusic[Random.Range(0,4)];
			GetComponent<AudioSource>().Play();
		}	
	
	}
}
