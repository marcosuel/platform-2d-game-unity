using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStatus
{
    private static int vidas, pontos;


    public static int Vidas 
    {
        get 
        {
            return vidas;
        }
        set 
        {
            vidas = value;
        }
    }

        public static int Pontos 
    {
        get 
        {
            return pontos;
        }
        set 
        {
            pontos = value;
        }
    }
    
}