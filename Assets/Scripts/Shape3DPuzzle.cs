using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shape3DPuzzle : MonoBehaviour
{
    private int shapeNumber;
    
    public XRBaseInteractable socketInteractor;
    
    // Start is called before the first frame update
    void Start()
    {
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
    }
    
    public void ClearCodeNumber(XRBaseInteractable placedShape)
    {
        /* pseudo code
         get socketNumber from the XR Socket Interactable component that this function should be called from
         have a switch determine which number place to set to 0 in enteredCodeNumber using socketNumber        
        */
    }
}
