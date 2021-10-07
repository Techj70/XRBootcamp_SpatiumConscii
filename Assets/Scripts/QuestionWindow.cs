using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionWindow : MonoBehaviour
{
    public float timeInterval = 30f; 
    private float waitTime = 30f;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // Check if we have reached beyond 2 seconds.
        // Subtracting two is more accurate over time than resetting to zero.
        if (timer > waitTime)
        {
            // Remove the recorded 2 seconds.
            timer = timer - waitTime;
        }
    }

    public void ShowQuestionWindow()
    {
        //QuestionText.GenerateQuestion();
        this.gameObject.SetActive(true);
    }

    public void HideQuestionWindow()
    {
        
    }
}
