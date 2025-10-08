using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LevelButtons: MonoBehaviour
{
    
    public void OpenLevel(int LevelId)
    {
        
        string LevelName = "Level" + LevelId;
        SceneManager.LoadScene(LevelName); 
    }
}
