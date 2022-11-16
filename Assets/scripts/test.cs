using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class test : MonoBehaviour
{

    /*private void HandleTranslate(){
        LeanTouch.LeanDragTranslate.IsActive = true;
    }*/
    private BoxCollider _boxcollider;
    void Start()
    {
        _boxcollider = GameObject.FindGameObjectWithTag("ItemImage").GetComponent<BoxCollider>();
    }

    
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
        //Destroy(GameObject.FindGameObjectWithTag("ItemImage"));

         RaycastHit2D raycast = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(obj.ScreenPosition), Vector2.zero);
         Debug.Log("tttt " + raycast.transform);

       // int id = raycast.transform.gameObject.GetComponent<test1>.id;
        //Debug.Log("tttt id " + id);


         
    }

}
