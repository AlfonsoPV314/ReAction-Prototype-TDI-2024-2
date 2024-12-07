using UnityEngine;

public class levelEditorManager : MonoBehaviour
{
    public itemController[] ItemButtons;

    public GameObject[] ItemPrefabs;

    public GameObject[] ItemImage;

    public int CurrentButtonPressed;

    private void Update(){
        Vector2 screenPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

        //left click ID = 0
        if(Input.GetMouseButtonDown(0) && ItemButtons[CurrentButtonPressed].clicked){
            ItemButtons[CurrentButtonPressed].clicked = false;
            Instantiate(ItemPrefabs[CurrentButtonPressed], new Vector3(worldPos.x, worldPos.y, 0), Quaternion.identity);
            // Destroy(GameObject.FindGameObjectWithTag("ItemImage"));
        }
    }
}
