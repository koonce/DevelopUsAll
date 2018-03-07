using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animating : MonoBehaviour {

    AudioSource audio;
    public AudioClip footsteps, drama, sword, shh;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update()
    {
      //  Animation anim = GetComponent<Animation>();
        RaycastHit hit;
        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Ray ray = new Ray(transform.position, transform.forward); 

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100.0f))
            {

                if (hit.transform.tag == "button")
                {
                   // Debug.Log("fuck");
                    //
                    hit.transform.GetComponent<Animator>().SetTrigger("clicked");
                    audio.PlayOneShot(footsteps);
                    
                }

                if (hit.transform.tag == "button2")
                {
                    hit.transform.GetComponent<Animator>().SetTrigger("clicked");
                    audio.PlayOneShot(drama, .5f);
                }

                if (hit.transform.tag == "button3")
                {
                    hit.transform.GetComponent<Animator>().SetTrigger("clicked");
                    audio.PlayOneShot(sword);
                }

                if (hit.transform.tag == "button4")
                {
                    hit.transform.GetComponent<Animator>().SetTrigger("clicked");
                }

                if (hit.transform.tag == "button5")
                {
                    hit.transform.GetComponent<Animator>().SetTrigger("clicked");
                }

                if (hit.transform.tag == "button6")
                {
                    hit.transform.GetComponent<Animator>().SetTrigger("clicked");
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            audio.PlayOneShot(shh, .5f);
        }
    }
}
