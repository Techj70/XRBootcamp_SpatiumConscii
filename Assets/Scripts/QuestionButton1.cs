using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionButton1 : MonoBehaviour
{
    private Text _textOnButton1;
    private GameObject _questionCanvasRef;
    
    // Start is called before the first frame update
    void Start()
    {
        _textOnButton1 = GetComponent<Text>();
        _questionCanvasRef = GameObject.FindGameObjectWithTag("Question_PopUp");
        Debug.Log(_questionCanvasRef.name + "found by tag");
        _textOnButton1.text = QuestionText.Button1Text;
    }

    // Update is called once per frame
    void Update()
    {
    }

}
