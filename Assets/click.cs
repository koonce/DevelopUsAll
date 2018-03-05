using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class click : MonoBehaviour {

    public bool[] events = new bool[10];
    public float timer = 7;
    public GameObject roped, instructions;
   public int i;
    AudioSource audio;
    string[] correct = new string[10];
    public AudioClip[] nextLine = new AudioClip[10];
    bool[] hasPlayed = new bool[10];
    public float timerSound;
    bool gameStarted = false;
    public Slider soundStuff;
    public int STRIKES = 0;


    public GameObject[] strikers = new GameObject[2];



    // Use this for initialization
    void Start() {
        hasPlayed[i] = false;
        i = 0;
        events[i] = false;
        }


    // Update is called once per frame
    void Update()
    {
        audio = GetComponent<AudioSource>();

        correct[0] = "button";
        correct[1] = "button2";
        correct[2] = "button5";
        correct[3] = "button3";
        correct[4] = "button6";


        // float mouseInputX = Input.GetAxis("Mouse X");
        // float mouseInputY = Input.GetAxis("Mouse Y");
        // Vector3 lookhere = new Vector3(-mouseInputY, mouseInputX, 0);
        // transform.Rotate(lookhere);
        //Debug.Log(transform.rotation.x);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -5, 0);
        }
        if (Input.GetKey(KeyCode.W) && transform.rotation.x < .5f)
        {
            transform.Rotate(-5, 0, 0);
           
        }
        if (Input.GetKey(KeyCode.S) && transform.rotation.x > -.5f)
        {
            transform.Rotate(5, 0, 0);
        }

        Vector3 newRotation = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0f);
        transform.eulerAngles = newRotation;

        if (timerSound >= 20)
        {
            STRIKES++;
            timerSound = 0;
        }

        if (events[i])
        {
            listen();
            if (!audio.isPlaying)
            {
                timer -= 1 * Time.deltaTime;
                if (timer <= 0)
                {
                    STRIKES++;
                    i++;
                }
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

        //    Debug.Log("time:" + timer);

        if (gameStarted)
        {
            timerSound += 1 * Time.deltaTime;
        }

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100.0f))
            {

                if (hit.transform.tag == "rope")
                {
                    roped.SetActive(false);
                    instructions.SetActive(false);
                    events[i] = true;
                    Debug.Log("game has started");
                    gameStarted = true;
                }


                if (hit.transform.tag == correct[i])
                {
                    if (!audio.isPlaying)
                    {
                        if (events[i])
                        {

                            timer = 7f;

                            Debug.Log("you hit it!");
                            i++;
                            events[i] = true;
                            events[i - 1] = false;


                        }
                    }
                    if (audio.isPlaying)
                    {
                        Debug.Log("scene manager is not working");
                        STRIKES++;
                    }

                }
                else if (hit.transform.tag.StartsWith("button") && gameStarted)
                {
                    Debug.Log("wrong button");
                    STRIKES++;
                }
                /* if (hit.transform.tag == "button2") {
                     if (events[1]) 
                     {
                         Debug.Log("you got it again!");
                     SceneManager.LoadScene(2);
                      //   events[1] = false;
                     }
                 }
                 */



            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform.tag == "crew" && timerSound >= 0)
                {
                    Debug.Log("Q");
                    timerSound -= 4f;
                }
            }
        }


    }

    private void FixedUpdate()
    {
        soundStuff.value = timerSound;

        if (STRIKES == 1)
        {
            strikers[0].SetActive(true);
        }
        if (STRIKES == 2)
        {
            strikers[1].SetActive(true);
        }

        if (STRIKES == 3)
        {
            SceneManager.LoadScene(1);
        }

        if (i == 5 && !audio.isPlaying)
        {
            SceneManager.LoadScene(2);
        }
    }

    void listen()
    {
        if (!hasPlayed[i])
        {
            audio.PlayOneShot(nextLine[i]);
            hasPlayed[i] = true;
        }
    }
    }
