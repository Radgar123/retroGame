using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeButtonToClick : MonoBehaviour
{
    public string sceneName;
    public string keyName;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyName))
            SceneManager.LoadScene(sceneName);
    }
}
