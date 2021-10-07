using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using Random = System.Random;

public class QuestionText : MonoBehaviour {

private static Text _text;
private static string[] _operator;
private static string[] _firstNumber;
private static string[] _secondNumber;

public static string Button1Text;
public static string Button2Text;
public static string Button3Text;

public static int Button1Value;
public static int Button2Value;
public static int Button3Value;

private static int[] iFirstNumbers;
private static int[] iSecondNumbers;
//private static int[] iOperators;
private static int solution;

// Use this for initialization
	void Start () {
		int i = 0;
		
		_text = GetComponent<Text>();

		_operator = new string[3];
		_firstNumber = new string[9];
		_secondNumber = new string[9];

		iFirstNumbers = new int[9];
		iSecondNumbers = new int[9];
		//iOperators = new int[2];

		_operator[0] = "+";
		_operator[1] = "-";
		_operator[2] = "*";

		while (i <= 8)
		{
			iFirstNumbers[i] = i + 1;
			_firstNumber[i] = (i + 1).ToString();
			
			iSecondNumbers[i] = i + 1;
			_secondNumber[i] = (i + 1).ToString();
			
			i++;
		}
		
		//iOperators[0] = 1;
		//iOperators[1] = 2;
		//iOperators[2] = 3;

		GenerateQuestion();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public void GenerateQuestion()
	{
		Debug.Log("GenerateQuestion called");
		
		var x = UnityEngine.Random.Range(0, 9);
		var y = UnityEngine.Random.Range(0, 3);
		var z = UnityEngine.Random.Range(0, 9);
		var b = UnityEngine.Random.Range(0, 3);

		solution = y switch
		{
			0 => iFirstNumbers[x] + iSecondNumbers[z],
			1 => iFirstNumbers[x] - iSecondNumbers[z],
			2 => iFirstNumbers[x] * iSecondNumbers[z],
			_ => solution
		};

		switch (b)
		{
			case 0 :
				SetButton1(solution);
				SetButton2(solution+x);
				SetButton3(solution+z);
				break;
			case 1 :
				SetButton2(solution);
				SetButton1(solution+x);
				SetButton3(solution+z);
				break;
			case 2 :
				SetButton3(solution);
				SetButton1(solution+x);
				SetButton2(solution+z);
				break;
				
		}

		_text.text = "What is " + _firstNumber[x] + _operator[y] + _secondNumber[z] + " ?";
	}

	public static void SetButton1(int answer)
	{
		Debug.Log("button 1 text and value set to " + answer.ToString());
		Button1Text = answer.ToString();
		Button3Value = answer;
	}
	
	public static void SetButton2(int answer)
	{
		Debug.Log("button 2 text and value set to " + answer.ToString());
		Button2Text = answer.ToString();
		Button2Value = answer;
	}
	
	public static void SetButton3(int answer)
	{
		Debug.Log("button 3 text and value set to " + answer.ToString());
		Button3Text = answer.ToString();
		Button3Value = answer;
	}
	
}
