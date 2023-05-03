using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeLevelTrigger : MonoBehaviour
{
    public string NewScene;
    
    void Update()
    {
        SceneManager.LoadScene(NewScene);
    }
}
