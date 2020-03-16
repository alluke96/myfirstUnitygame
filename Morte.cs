using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Morte : MonoBehaviour
{
    private int vidas = 3;
    public Image vida1Image, vida2Image, vida3Image;
    public Text txt;
    public Vector3 spawnPoint;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < 20)
        {
            switch (vidas){
                case 3: Destroy(vida3Image);
                    txt.text = "Você pode cair mais 2x para fora do mapa";
                    break;
                case 2: Destroy(vida2Image);
                    txt.text = "Você pode cair mais 1x para fora do mapa";
                    break;
                case 1: Destroy(vida1Image);
                    break;
            }
            vidas--;
            //Destroy(gameObject);
            if (vidas != 0)
            {
                gameObject.transform.position = spawnPoint;
                //Instantiate(gameObject);
            }
            else
                SceneManager.LoadScene("EndingScene");
        }
    }
}
