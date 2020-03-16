using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    Scene cena;
    string nomeCena;
    void Start()
    {
        cena = SceneManager.GetActiveScene();
        nomeCena = cena.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (nomeCena == "MenuScene" && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");
        }
        
        if (nomeCena == "EndingScene" && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
