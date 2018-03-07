using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newAnimate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100.0f))
            {

                if (hit.transform.tag == "button")
                {
                //    Debug.Log("we hit it");
                }
            }
        }
    }
}
