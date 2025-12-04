using UnityEngine;   // ← ЭТО ОБЯЗАТЕЛЬНО

public class PuzzleManager : MonoBehaviour
{
    public PieceSnap[] pieces;
    public GameObject blurPanel;
    public GameObject victoryWindow;
    public GameObject confetti;

    private bool puzzleCompleted = false;

    void Start()
    {
        blurPanel.SetActive(false);
        victoryWindow.SetActive(false);
        confetti.SetActive(false);
    }

    void Update()
    {
        if (puzzleCompleted) return;

        for (int i = 0; i < pieces.Length; i++)
        {
            if (!pieces[i].IsSnapped())
                return;
        }

        puzzleCompleted = true;

        blurPanel.SetActive(true);
        victoryWindow.SetActive(true);
        confetti.SetActive(true);
    }
}