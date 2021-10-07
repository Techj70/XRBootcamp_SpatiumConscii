using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeInterval = 30f; 
    private float waitTime = 30f;
    private float _timer = 0.0f;

    public GameObject QuestionCanvasPrefab; //use editor to place value for this game object

    // Start is called before the first frame update
    void Start()
    {
        //QuestionWindowRef.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        
        //Debug.Log(_timer);

        // Check if we have reached beyond 2 seconds.
        // Subtracting two is more accurate over time than resetting to zero.
        if (GameObject.FindWithTag("Question_PopUp") == true)
        {
            _timer = 0;
        }
        
        else if (_timer > waitTime)
        {
            Debug.Log("time for question");
            Instantiate(QuestionCanvasPrefab);
            _timer = 0;
        }

        
    }
    
}
