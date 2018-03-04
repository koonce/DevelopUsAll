using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crewNoise : MonoBehaviour {
    AudioSource audio;
    public Slider volumeControl;
    public float multiplier = .05f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        audio = GetComponent<AudioSource>();
        audio.volume = volumeControl.value * multiplier;

    }
}
