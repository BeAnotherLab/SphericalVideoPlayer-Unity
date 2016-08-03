using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class VideoPlayer : MonoBehaviour {
	
	private AudioClip myAudioClip;
	MovieTexture myMovieTexture;
	AudioSource myMovieAudio;

	private bool isPlaying = false;

	// Use this for initialization
	void Start () {
	
		myMovieTexture = (MovieTexture)GetComponent<Renderer> ().material.mainTexture;
		myMovieTexture.loop = false;

		float frame = myMovieTexture.duration;
		Debug.Log ("The duration of this video is: " + frame + " seconds");

		myMovieAudio = (AudioSource)GetComponent<AudioSource>();
		myMovieAudio.clip = myMovieTexture.audioClip;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			
			if (!isPlaying) {
				myMovieTexture.Play ();
				myMovieAudio.Play ();
				isPlaying = true;
			}

			else if (isPlaying) {
				myMovieTexture.Pause ();
				myMovieAudio.Pause ();
				isPlaying = false;
			}
		
		}
		if (Input.GetKeyDown ("return")) {
			myMovieTexture.Stop ();
			myMovieAudio.Stop ();
			}
		}
}
