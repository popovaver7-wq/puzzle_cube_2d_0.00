using UnityEngine;

public class WorldButton : MonoBehaviour
{
    public GameObject questionPanel;

    void OnMouseDown()
    {
        questionPanel.SetActive(true);
    }
}
