using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Выход из игры"); // это для проверки в Unity Editor
        Application.Quit();
    }
}