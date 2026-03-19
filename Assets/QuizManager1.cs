using UnityEngine;
using UnityEngine.UI;

using UnityEngine;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public GameObject questionPanel;
    public GameObject resultImage;
    public TMP_InputField answerInput;

    private bool answeredCorrectly = false;

    public void OpenQuestion()
    {
        if (!answeredCorrectly)
        {
            questionPanel.SetActive(true);
        }
    }

    public void CloseQuestion()
    {
        questionPanel.SetActive(false);
    }

    public void CheckAnswer()
    {
        string answer = answerInput.text.ToLower();

        if (answer == "jelen")
        {
            answeredCorrectly = true;
            questionPanel.SetActive(false);
            resultImage.SetActive(true);
        }
        else
        {
            Debug.Log("zla odpowiedz");
        }
    }
}


