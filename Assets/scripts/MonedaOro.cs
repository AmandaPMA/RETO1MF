using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaOro : MonoBehaviour
{

    public int valor = 1;
    public GameManager1 gameManager1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameManager1.SumarPuntos(valor);
            Destroy(this.gameObject);
        }
        
    }
} 
