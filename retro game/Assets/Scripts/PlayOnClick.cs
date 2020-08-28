using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayOnClick : MonoBehaviour
{
    public string scena;
    public GameObject panel;

    public void Update() 
    {
        if (Input.anyKeyDown) 
        {
            //SceneManager.LoadScene(scena);
            Time.timeScale = 1f;
            Destroy(gameObject);
            OpenPanel();
        }
    }

    public void OpenPanel() 
    {
        if (panel != null) 
        {
            //bool isActive = panel.asctiveSelf;
            panel.SetActive(true);
        }
    }
}
