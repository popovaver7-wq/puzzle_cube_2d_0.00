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

    // Вопрос 1
    public void CheckAnswer1()
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

    // Вопрос 2
    public void CheckAnswer2()
    {
        string answer = answerInput.text.ToLower();

        if (answer == "kot")
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

    // Вопрос 3
    public void CheckAnswer3()
    {
        string answer = answerInput.text.ToLower();

        if (answer == "motyl")
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

    // Вопрос 4
    public void CheckAnswer4()
    {
        string answer = answerInput.text.ToLower();

        if (answer == "wielblad")
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

    // Вопрос 5
    public void CheckAnswer5()
    {
        string answer = answerInput.text.ToLower();

        if (answer == "kangur")
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

    // Вопрос 6
    public void CheckAnswer6()
    {
        string answer = answerInput.text.ToLower();

        if (answer == "kogut")
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


