using UnityEngine;

public class manItem : MonoBehaviour
{

    public int ID;

    private levelEditorManager editor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        editor = GameObject.FindGameObjectWithTag("LevelEditorManager").GetComponent<levelEditorManager>();
    }

    private void OnMouseOver(){
        if (Input.GetMouseButtonDown(1)){
            Destroy(this.gameObject);
            editor.ItemButtons[ID].quantity++;
            editor.ItemButtons[ID].quantityText.text = editor.ItemButtons[ID].quantity.ToString();
        }
    }

    
}
