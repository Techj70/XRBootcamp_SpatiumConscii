using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRHand : MonoBehaviour
{
    public float speed;
    
    private Animator _animator;
    private float _gripTarget;
    private float _triggerTarget;
    private float _gripCurrent;
    private float _triggerCurrent;
    private string _animatorGripParam = "Grip";
    private string _animatorTriggerParam = "Trigger";
    

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    private void AnimateHand()
    {
        if (_gripCurrent != _gripTarget)
        {
            _gripCurrent = Mathf.MoveTowards(_gripCurrent, _gripTarget, Time.deltaTime * speed);
            _animator.SetFloat(_animatorGripParam,_gripCurrent);
        }
        
        if (_triggerCurrent != _triggerTarget)
        {
            _triggerCurrent = Mathf.MoveTowards(_triggerCurrent, _triggerTarget, Time.deltaTime * speed);
            _animator.SetFloat(_animatorTriggerParam,_triggerCurrent);
            
        }
    }

    internal void SetGrip(float v)
    {
        _gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        _triggerTarget = v;
    }
    
}