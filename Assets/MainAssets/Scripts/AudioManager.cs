using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioSource backgroungMusic;
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void changeBGM(AudioClip music)
    {
        if(backgroungMusic.clip.name == music.name)
        {
            return;
        }
        backgroungMusic.Stop();
        backgroungMusic.clip = music;
        backgroungMusic.Play();
    }
}
