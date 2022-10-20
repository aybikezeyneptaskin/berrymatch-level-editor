using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class test : MonoBehaviour
{
    /*private void OnEnable()
    {
        Debug.Log("onenable");
        LeanTouch.OnFingerUp += HandleFingerUp;
    }
    private void OnDisable()
    {
        Debug.Log("ondisable");
        LeanTouch.OnFingerUp -= HandleFingerUp;
    }

    private void HandleFingerUp(LeanFinger obj)
    {
        Debug.Log("destroy");
        Destroy(GameObject.FindGameObjectWithTag("ItemImage"));
        
    }*/
    private void OnEnable()
    {
        Debug.Log("onenable");
        LeanTouch.OnFingerTap += HandleFingerTap;
    }
    private void OnDisable()
    {
        Debug.Log("ondisable");
        LeanTouch.OnFingerTap -= HandleFingerTap;
    }

    private void HandleFingerTap(LeanFinger obj)
    {
        Debug.Log("destroy");
        Destroy(GameObject.FindGameObjectWithTag("ItemImage"));
    }
}
