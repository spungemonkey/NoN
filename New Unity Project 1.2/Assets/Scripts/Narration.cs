using UnityEngine;
using System.Collections;

public class Narration : MonoBehaviour {
	public AudioClip[] ac;
	int j = 0;
	bool playAudio = true;
	float audioTime = 0.0f;
	public float accelerator = 1.0f;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		
		if (playAudio) {
			if (!audio.isPlaying && j <= ac.Length){
				audio.clip = ac [j];
				audio.Play ();
				//j = j + 1;
				//audio.clip = null;
				if (j > 0)
				{
					ac[j-1] = null;
				}
				++j;
			}

			if (j >= ac.Length){
				audioTime+=Time.deltaTime;
				if (audioTime>audio.clip.length-accelerator)
				{
					j = 0;
					playAudio = false;
					audio.clip = null;
				}
			}
			
		}
	
	}
}
