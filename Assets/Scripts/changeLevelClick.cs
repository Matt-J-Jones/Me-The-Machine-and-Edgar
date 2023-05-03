using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeLevelClick : MonoBehaviour
{
    public string NewScene;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(NewScene);   
    }

}
