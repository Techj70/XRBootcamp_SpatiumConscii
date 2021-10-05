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
    
    [SerializeField] public XRSocketInteractor[] socket;
    [SerializeField] public string[] code;

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
                break;
            case "RectSolid":
                Debug.Log("rectangle placed");
                break;
            case "PrismTall":
                Debug.Log("prism tall placed");
                break;
            case "PrismLong":
                Debug.Log("prism long placed");
                break;
            case "Pyramid":
                Debug.Log("pyramid placed");
                break;
            case "Sphere":
                Debug.Log("sphere placed");
                break;
            case "Cylinder":
                Debug.Log("cylinder placed");
                break;
            
        }
    
}
    
    public void ClearCodeNumber(XRBaseInteractable placedShape)
    {
        /* pseudo code
         get socketNumber from the XR Socket Interactable component that this function should be called from
         have a switch determine which number place to set to 0 in enteredCodeNumber using socketNumber        
        */
    }
}
