using UnityEngine;

public class followMouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        transform.position = worldPos;
    }
}
