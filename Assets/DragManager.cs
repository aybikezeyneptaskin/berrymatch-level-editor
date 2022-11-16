using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
 

 
public class DragManager : MonoBehaviour
{
 
    RaycastHit2D Hit;
    Ray ray;
    Camera MainCam;
    bool IsDragging;
    GameObject Selected;
    bool Clicked;
    public LayerMask ClickedUp;
    public LayerMask ClickedDown;
    Vector2 PrevPos;
 
    // Use this for initialization
    void Start()
    {
        MainCam = Camera.main;
    }
 
    // Update is called once per frame
    void Update()
    {
        CheckClick();
        if (IsDragging)
        {
            ray = MainCam.ScreenPointToRay(Input.mousePosition);
            Selected.transform.position = ray.origin;

            Debug.Log("ray"+ray.origin);
        }
    }
 
    void CheckClick()
    {
        if (Input.GetMouseButtonDown(0) && !IsDragging)
        {
            ray = MainCam.ScreenPointToRay(Input.mousePosition);
            Hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, ClickedDown);
            if (Hit != null && Hit.collider != null)
            {
                if (Hit.transform.tag.Contains("Moving"))
                {
                    IsDragging = true;
                    Selected = Hit.transform.gameObject;
                }
            }
 
        }
        if (Input.GetMouseButtonUp(0))
        {
 
            IsDragging = false;
            ray = MainCam.ScreenPointToRay(Input.mousePosition);
            Hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, ClickedUp);
 
            if (Hit != null && Hit.collider != null)
            {
             
              //Selected.transform.position = Hit.transform.position;
              
              
                print(Hit.collider.tag);
                if (Hit.transform.tag.Contains("Board"))
                {
                    Selected.transform.position = Hit.transform.position;
                }
                else
                {
                    Selected.transform.position = PrevPos;
 
                }
            }
        }
        
         }
    }
