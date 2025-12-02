using UnityEngine;

public class PieceSnap : MonoBehaviour
{
    public Transform targetPoint;      // куда должен попасть кусок
    public float snapDistance = 0.15f; // точность прилипания
    private bool snapped = false;

    private void OnMouseUp()   // вызывается, когда отпускаешь мышку
    {
        if (snapped) return;

        float dist = Vector2.Distance(transform.position, targetPoint.position);

        // если кусок достаточно близко — прилипает
        if (dist < snapDistance)
        {
            transform.position = targetPoint.position;
            snapped = true;

            // выключаем перетаскивание, чтобы больше не двигался
            GetComponent<DragPiece>().enabled = false;
        }
    }

    public bool IsSnapped()
    {
        return snapped;
    }
}
