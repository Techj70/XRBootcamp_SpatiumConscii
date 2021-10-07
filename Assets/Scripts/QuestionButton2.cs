using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionButton2 : MonoBehaviour
{
    private Text _textOnButton2;
    private GameObject _questionCanvasRef;
        
    // Start is called before the first frame update
    void Start()
    {
        _textOnButton2 = GetComponent<Text>();
        _questionCanvasRef = GameObject.FindGameObjectWithTag("Question_PopUp");
        Debug.Log(_questionCanvasRef.name + "found by tag");
        _textOnButton2.text = QuestionText.Button2Text;
    }

    // Update is called once per frame
    void Update()
    {
    }

}
