using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
//This script is used to display the timer on the screen.
//It also loads the game over scene when the timer reaches 0.
public class Timer : MonoBehaviour
{
    //The text that displays the timer
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public GameObject JumpScare;
    private bool active;
    public AudioSource source;
    public AudioClip clip;
    
    
    // This update is used to change the time each frame.
    void Update()
    {
        if (remainingTime < 455 && remainingTime > 454)
        {
            source.PlayOneShot(clip);
        }
        if (remainingTime < 455 && remainingTime>453)
        {
            active = !active;
            JumpScare.SetActive(active);
        }

        if (remainingTime < 453)
        {
            JumpScare.SetActive(false);
        }
        
        if(remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            //Loads the game over scene
            SceneManager.LoadScene(3);
        }
        //This is used to display the time in minutes and seconds.
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

