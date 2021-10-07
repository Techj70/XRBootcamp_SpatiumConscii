using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionButton3 : MonoBehaviour
{
    private Text _textOnButton3;
    private GameObject _questionCanvasRef;
    
    // Start is called before the first frame update
    void Start()
    {
        _textOnButton3 = GetComponent<Text>();
        _questionCanvasRef = GameObject.FindGameObjectWithTag("Question_PopUp");
        Debug.Log(_questionCanvasRef.name + "found by tag");
        _textOnButton3.text = QuestionText.Button3Text;
    }

    // Update is called once per frame
    void Update()
    {
    }
    
}