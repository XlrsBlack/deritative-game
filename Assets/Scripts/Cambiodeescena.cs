using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiodeescena : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        string name = "Lv1";
        bool arranque = Input.anyKey;
        if (arranque)
        {
            SceneManager.LoadScene(name);
         
        }

        bool salir = Input.GetKeyDown(KeyCode.Escape);
            if(salir)
        {
            Application.Quit(); 
        }
    }
}
