using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class levelbuttons: MonoBehaviour
{

    public void openlevel(int levelid)
    {
        string levelname = "level" + levelid;
        SceneManager.LoadScene(levelname);
    }
}
