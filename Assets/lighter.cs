using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lighter : MonoBehaviour
{
    public GameObject lighting, rope, rope2, player, gameStarter;
    public float timer = 20;
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
        int strikes = player.GetComponent<click>().STRIKES;

        if (!gameStarter.activeSelf)
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
                if (timer <= 20)
                {
                    timer += 1 * Time.deltaTime;
                }
            }

            if (timer <= 0)
            {
                strikes++;
                timer = 20;
                lightOn = false;
            }
        }
        player.GetComponent<click>().STRIKES = strikes;
    }

}
