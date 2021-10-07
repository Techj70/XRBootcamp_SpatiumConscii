using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    private Text _text;
    public static float stopWatch = 0.0f;
    public static int seconds = 0; 
    
    // Start is called before the first frame update
    void Start()
    {
        _text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        stopWatch += Time.deltaTime;
        seconds = Mathf.RoundToInt(stopWatch);
        _text.text = seconds.ToString();
    }
}
