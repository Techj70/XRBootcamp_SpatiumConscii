using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendSocketNumber : MonoBehaviour
{
    [SerializeField] public int assignedSocketNumber;
    // Start is called before the first frame update
    void Start()
    {
      if (assignedSocketNumber == 0)
      {
          Debug.Break();
          Debug.LogError("error, Assigned Socket Number not entered for Send Socket Number component on " + gameObject.name);
      }  
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SendNumber()
    {
        SendMessage("GetSocketNumber", assignedSocketNumber);
    }
}
