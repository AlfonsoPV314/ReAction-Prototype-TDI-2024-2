using UnityEngine;
using UnityEngine.UI;

public class itemController : MonoBehaviour
{
    public int ID;

    public int quantity;

    [SerializeField] public Text quantityText;

    public bool clicked = false;

    private levelEditorManager editor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        quantityText.text = quantity.ToString();
        editor = GameObject.FindGameObjectWithTag("LevelEditorManager").GetComponent<levelEditorManager>();
    }

    public void buttonClicked(){
        if (quantity > 0){
            Vector2 screenPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
            clicked = true;
            quantity--;
            quantityText.text = quantity.ToString();
            // Instantiate(editor.ItemImage[ID], new Vector3(worldPos.x, worldPos.y, 0), Quaternion.identity);
            // editor.CurrentButtonPressed = ID;
        }
    }
}

// commented lines are as such because I want it to have a pre-image of the object that it calls that follows the player's mouse so the player
// can know how the object looks before instantiating it. However, de-commenting the commented lines results in error:
// NullReferenceException: Object reference not set to an instance of an object
// itemController.buttonClicked () (at Assets/Scripts/itemController.cs:30)

// I do not know why this happens. Why does it want the pre-image object to be instantiated in the line of the instantiation?