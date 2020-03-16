using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio3Chave : MonoBehaviour
{
    private bool pegouChave = false;
    private bool portaAberta = false; // Para futuros updates, nao faz nada ainda. Ignorar o Warning :)

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Chave")
        {
            pegouChave = true;
            Debug.Log("Peguei a chave!");
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Porta")
        {
            if (pegouChave == true)
            {
                portaAberta = true;
                Debug.Log("Abri a porta!");
                Destroy(other.gameObject);
            }
        }
    }
}
