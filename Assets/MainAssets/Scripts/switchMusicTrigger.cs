using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchMusicTrigger : MonoBehaviour {
    public AudioClip newTrack;

    private AudioManager theAM;
	// Use this for initialization
	void Start () {
        theAM = FindObjectOfType<AudioManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (newTrack != null)
            {
                theAM.changeBGM(newTrack);
            }
        }
    }
}
