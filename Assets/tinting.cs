using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tinting : MonoBehaviour {
    public Material[] originalColor = new Material[6];
    public GameObject[] interactable = new GameObject[6];
    public Material tint;
    string[] tags = new string[8];
    public GameObject Lpencil, LpencilTint, Rpencil, RpencilTint, rope, ropeTint;

    int i;

    // Use this for initialization
    void Start () {
        tags[0] = "button";
        tags[1] = "button2";
        tags[2] = "button3";
        tags[3] = "button4";
        tags[4] = "button5";
        tags[5] = "button6";
        // tags[6] = "rope";
        // tags[7] = "crew";

    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        /*
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            if (hit.transform.tag == tags[i])
            {

            }
        }
        */

        //TINT HOPEFULLY
        // Material newMaterial = new Material(Shader.Find("Wha)"));
        Material colorChange = interactable[i].GetComponent<MeshRenderer>().material;
       // for(i = 0; i < tags.Length; i++)
    //    {
            if (Physics.Raycast(ray, out hit, 100.0f))
            {

            if (hit.transform.tag == tags[0])
            {
                interactable[0].GetComponent<MeshRenderer>().material.color = tint.color;
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("HEY!");
                }
            }
            else
            {
                interactable[0].GetComponent<MeshRenderer>().material.color = originalColor[0].color;
            }

            if (hit.transform.tag == tags[1])
            {
                interactable[1].GetComponent<MeshRenderer>().material.color = tint.color;
            }
            else
            {
                interactable[1].GetComponent<MeshRenderer>().material.color = originalColor[1].color;
            }

            if (hit.transform.tag == tags[2])
            {
                interactable[2].GetComponent<MeshRenderer>().material.color = tint.color;
            }
            else
            {
                interactable[2].GetComponent<MeshRenderer>().material.color = originalColor[2].color;
            }
            if (hit.transform.tag == tags[3])
            {
                interactable[3].GetComponent<MeshRenderer>().material.color = tint.color;
            }
            else
            {
                interactable[3].GetComponent<MeshRenderer>().material.color = originalColor[3].color;
            }
            if (hit.transform.tag == tags[4])
            {
                interactable[4].GetComponent<MeshRenderer>().material.color = tint.color;
            }
            else
            {
                interactable[4].GetComponent<MeshRenderer>().material.color = originalColor[4].color;
            }
            if (hit.transform.tag == tags[5])
            {
                interactable[5].GetComponent<MeshRenderer>().material.color = tint.color;
            }
            else
            {
                interactable[5].GetComponent<MeshRenderer>().material.color = originalColor[5].color;
            }


            if (hit.transform.tag == "Lpencil")
            {
                LpencilTint.SetActive(true);
                Lpencil.SetActive(false);
                Debug.Log("pencil baby");
            }
            else
            {
                Lpencil.SetActive(true);
                LpencilTint.SetActive(false);
            }

            if (hit.transform.tag == "Rpencil")
            {
                RpencilTint.SetActive(true);
                Rpencil.SetActive(false);
            }
            else
            {
                Rpencil.SetActive(true);
                RpencilTint.SetActive(false);
            }

            if (hit.transform.tag == "rope")
            {
                ropeTint.SetActive(true);
                rope.SetActive(false);
            }
            else
            {
                rope.SetActive(true);
                ropeTint.SetActive(false);
            }

        }

   //     }

    }
}
