using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lighter : MonoBehaviour
{
    public GameObject lighting, rope;
    public float timer = 10;
    public bool lightOn = false;
    // Use this for initialization
    public Slider timerFeedback;
    public bool gameStarted = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!rope.activeSelf)
        {
            gameStarted = true;
        }

        timerFeedback.value = timer;

        if (gameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("YES");
                if (lightOn)
                {
                    lightOn = false;
                }
                else if (!lightOn)
                {
                    lightOn = true;
                }
            }
            if (lightOn)
            {
                {
                    lighting.SetActive(true);
                }

                timer -= 1 * Time.deltaTime;
            }
            if (!lightOn)
            {
                lighting.SetActive(false);
                if (timer <= 10)
                {
                    timer += 1 * Time.deltaTime;
                }
            }

            if (timer <= 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

}
