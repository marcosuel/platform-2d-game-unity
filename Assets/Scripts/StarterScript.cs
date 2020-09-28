using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterScript : MonoBehaviour
{
    public int vidas, pontos;
    
    private void Start()
    {
        PlayerStats.Vidas = vidas;
        PlayerStats.Pontos = pontos;
    }
}
