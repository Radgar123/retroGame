using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    

    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {

            //Destroy(gameObject);
            Debug.Log("umar");
            
            lifeCounter.heart -= 1;

            if (lifeCounter.heart == 0) 
            {
                Destroy(gameObject);
                OpenPanel();

            }
        }

        if (collision.gameObject.tag == "asteroid")
        {
            Destroy(gameObject);
            Debug.Log("umar");
            OpenPanel();
        }

        if (collision.gameObject.tag == "Cure")
        {
            lifeCounter.heart += 1;
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
