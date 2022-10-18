using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
using TMPro;

public class ItemController : MonoBehaviour
{
    public int ID;
    public int quantity;
    public TextMeshProUGUI quantityText;
    public bool clicked = false;
    private LevelEditorManager _editor;
    void Start()
    {
        quantityText.text = quantity.ToString();
        _editor = GameObject.FindGameObjectWithTag("LevelEditorManager").GetComponent<LevelEditorManager>();
    }
    
    public void ButtonClicked()
    {
        if (quantity > 0)
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y); 
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            Instantiate(_editor.ItemImage[ID], new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);
            clicked = true;
            quantity--;
            quantityText.text = quantity.ToString();
            _editor.CurrentButtonPressed = ID;

        }
    }
}
