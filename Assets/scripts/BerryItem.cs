using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;
using CW.Common;

public class BerryItem : MonoBehaviour
{
    public int ID;
    private LevelEditorManager _editor;
    void Start()
    {
        _editor = GameObject.FindGameObjectWithTag("LevelEditorManager").GetComponent<LevelEditorManager>();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("destroying..");
            //DestroyNow();
            Destroy(this.gameObject);
            _editor.ItemButtons[ID].quantity++;
            _editor.ItemButtons[ID].quantityText.text = _editor.ItemButtons[ID].quantity.ToString();
        }
    }
   
}