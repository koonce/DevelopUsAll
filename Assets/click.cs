using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {

    public bool[] events = new bool[10];
    public float timer;
    public GameObject youWin, youLose;
    int i;

    // Use this for initialization
    void Start() {
        i = 0;
        }

    // Update is called once per frame
    void Update() {

        float mouseInputX = Input.GetAxis("Mouse X");
        float mouseInputY = Input.GetAxis("Mouse Y");
        Vector3 lookhere = new Vector3(-mouseInputY, mouseInputX, 0);
        transform.Rotate(lookhere);

        Vector3 newRotation = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0f);
        transform.eulerAngles = newRotation;


        if (Input.GetKeyDown(KeyCode.Space)) {
            events[i] = true;
            Debug.Log("game has started");
            }

        if (events[i]) {
            timer -= 1 * Time.deltaTime;
            if (timer <= 0) {
                youLose.SetActive(true);
                events[i] = false;
                }
            }

       /* if (eventTwo) {
            timer -= 1 * Time.deltaTime;
            if (timer <= 0) {
                youLose.SetActive(true);
                eventTwo = false;
                }
            }
            */

            Debug.Log("time:" + timer);

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Input.GetMouseButtonDown(0)) {
                if (Physics.Raycast(ray, out hit, 100.0f)) {
                    //Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
                    if (hit.transform.tag == "button") {
                        if (events[0]) {
                            events[1] = true;
                            timer = 5f;
                            Debug.Log("you hit it!");
                            events[0] = false;
                        i++;
                            }

                        }
                    if (hit.transform.tag == "button2") {
                        if (events[1]) 
                        {
                            Debug.Log("you got it again!");
                            youWin.SetActive(true);
                            events[1] = false;
                        }
                    }
                    

                }
            }
        }
    }
