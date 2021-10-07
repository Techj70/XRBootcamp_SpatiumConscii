using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCounter : MonoBehaviour
{
    private Text _text;
    
    // Start is called before the first frame update
    void Start()
    {
        _text = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = Shape3DPuzzle.moveCounter.ToString(); 
    }
}
