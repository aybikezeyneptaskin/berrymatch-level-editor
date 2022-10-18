using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelEditorManager : MonoBehaviour
{
    public ItemController[] ItemButtons; //array
    public GameObject[] ItemPrefabs; //array
    public GameObject[] ItemImage; //array
    public int CurrentButtonPressed;
    
    private void Update()
    {
        //instantiate an object at your mouse position
        //update where our mouse position is
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y); 
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        
        //0 = left click, && if actually clicked
        if (Input.GetMouseButtonDown(0) && ItemButtons[CurrentButtonPressed].clicked)
        {
            ItemButtons[CurrentButtonPressed].clicked = false;
            Instantiate(ItemPrefabs[CurrentButtonPressed], new Vector3(worldPosition.x, worldPosition.y, 0),
                Quaternion.identity);
            Destroy(GameObject.FindGameObjectWithTag("ItemImage"));
        }
    }
}