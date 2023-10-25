using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public GameManager1 gameManager1;
    public TextMeshProUGUI puntos;

    // Update is called once per frame
    void Update()
    {
        puntos.text = gameManager1.PuntosTotales.ToString();
    }
}
