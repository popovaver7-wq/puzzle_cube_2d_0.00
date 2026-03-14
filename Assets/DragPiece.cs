using UnityEngine;

public class DragPiece : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    private void OnMouseDown()
    {
       
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - new Vector3(mouseWorld.x, mouseWorld.y, 0) ;
        isDragging = true;
        Debug.Log("kliknieto element puzzla");
        Debug.Log("isDragging po kliknieciu:" + isDragging);
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {
        if (isDragging)
        {
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mouseWorld.x, mouseWorld.y, 0) + offset;
        }
    }
}
