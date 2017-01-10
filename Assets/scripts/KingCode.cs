using UnityEngine;
using System.Collections;

public class KingCode : MonoBehaviour {
	
	float stabilizeTimer=0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (transform.position.y<-300) Destroy(gameObject);
		
		//if the king gets knocked off pedestal then its gameover
		if (transform.position.y<10) MainGameCode.GameOver();
		
		if (stabilizeTimer>0) stabilizeTimer-=Time.deltaTime;
		if (stabilizeTimer<0)  {
			stabilizeTimer=0;
			GetComponent<Rigidbody>().WakeUp(); }
		
	}
	
	void OnCollisionEnter(Collision col) {
		MakeGrunt();
	}	
	
	public void Stabilize() {
		GetComponent<Rigidbody>().Sleep();
		stabilizeTimer=2;
		
	}	
	
	void MakeGrunt() {
		if (MainGameCode.gamestate!=GAMESTATE.TITLE)
		AudioSource.PlayClipAtPoint(PrefabManager.kingHitSound,PrefabManager.soundController.transform.position);	
	}	
}
