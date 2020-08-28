using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    [SerializeField]  string scena1;


    public void Update() 
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene(scena1);
            //Time.timeScale = 1f;
        }

    }


    public void Play(string scene) 
    {
        StartCoroutine(LoadAfterDelay(scene, 1f));
    }

    public IEnumerator LoadAfterDelay(string scene, float seconds) 
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(scene);
    }

    public void Exit() 
    {
        Application.Quit();
    }
  
}
