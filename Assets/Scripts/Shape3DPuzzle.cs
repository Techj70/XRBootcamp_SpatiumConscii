using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shape3DPuzzle : MonoBehaviour
{
    private int shapeNumber;
    private int arrayX = 1; //used to start array at 1 for easy of use with socket numbers in the editor

    private int socketNumber = 0;
    
    [SerializeField] public XRSocketInteractor[] socket;
    [SerializeField] public string[] codeSolution; //the code need to solve the puzzle
    [SerializeField] public string[] code; //the code inputted by the user
    

    public Shape3D socketedShape;

    private void Start()
    {
    }

    void Awake()
    {
        while (arrayX <= 27)
        {
            socket[arrayX].onSelectEntered.AddListener(CheckShape);
            socket[arrayX].onSelectExited.AddListener(ClearCodeNumber);
            arrayX++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckShape(XRBaseInteractable placedShape)
    {
        /* pseudo code
         get socketNumber from the XR Socket Interactable component that this function should be called from
         get shape of placedShape by checking its components for a shape script and have a switch use it to determine what number to assign to shapeNumber
         have another switch determine which value to add to to enteredCodeNumber using shapeNumber and socketNumber        
        */
        socketedShape = placedShape.GetComponent<Shape3D>();

        switch (socketedShape.shapeName)
        {
            case "Cube":
                Debug.Log("cube placed");
                if (socketNumber <= 0)
                {
                    Debug.Log("error, socket number read as 0"); 
                    break;
                }
                code[socketNumber] = "1";
                Debug.Log("code["+ socketNumber +"] set to 1");
                break;
            case "RectSolid":
                Debug.Log("rectangle placed");
                if (socketNumber <= 0)
                {
                    Debug.Log("error, socket number read as 0"); 
                    break;
                }
                code[socketNumber] = "2";
                Debug.Log("code["+ socketNumber +"] set to 2");
                break;
            case "PrismTall":
                Debug.Log("prism tall placed");
                if (socketNumber <= 0)
                {
                    Debug.Log("error, socket number read as 0"); 
                    break;
                }
                code[socketNumber] = "3";
                Debug.Log("code["+ socketNumber +"] set to 3");
                break;
            case "PrismLong":
                Debug.Log("prism long placed");
                if (socketNumber <= 0)
                {
                    Debug.Log("error, socket number read as 0"); 
                    break;
                }
                code[socketNumber] = "4";
                Debug.Log("code["+ socketNumber +"] set to 4");
                break;
            case "Pyramid":
                Debug.Log("pyramid placed");
                if (socketNumber <= 0)
                {
                    Debug.Log("error, socket number read as 0"); 
                    break;
                }
                code[socketNumber] = "5";
                Debug.Log("code["+ socketNumber +"] set to 5");
                break;
            case "Sphere":
                Debug.Log("sphere placed");
                if (socketNumber <= 0)
                {
                    Debug.Log("error, socket number read as 0"); 
                    break;
                }
                code[socketNumber] = "6";
                Debug.Log("code["+ socketNumber +"] set to 6");
                break;
            case "Cylinder":
                Debug.Log("cylinder placed");
                if (socketNumber <= 0)
                {
                    Debug.Log("error, socket number read as 0"); 
                    break;
                }
                code[socketNumber] = "7";
                Debug.Log("code["+ socketNumber +"] set to 7");
                break;
            
        }

        Debug.Log("current code is " + code);

    }

    public void GetSocketNumber (int receivedSocketNumber)
    {
        socketNumber = receivedSocketNumber;
    }

    public void ClearCodeNumber(XRBaseInteractable placedShape)
    {
        /* pseudo code
         get socketNumber from the XR Socket Interactable component that this function should be called from
         have a switch determine which number place to set to 0 in enteredCodeNumber using socketNumber        
        */
        code[socketNumber] = "0";
        Debug.Log(("shape removed from " + socketNumber+ " and code[" + socketNumber + "] set to 0"));
    }

    public void CheckSolution()
    {
        if (code == codeSolution)
        {
        }
    }
}
