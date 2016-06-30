/*
Description Script:
Name:
Date:
Upgrade:
*/
using UnityEngine;
using System.Collections;

/// <summary>
/// imp
/// </summary>
public class CameraManager : Singleton<CameraManager>
{
    /// <summary>
    /// Valor do largura maxima de acordo com as coordenadas da camera
    /// </summary>
    public float bottomRight;
    /// <summary>
    /// Valor da largura minima de acordo com as coordenadas da camera
    /// </summary>
    public float bottomLeft;
    /// <summary>
    /// Valor da altura maxima de acordo com as coordenadas da camera
    /// </summary>
    public float bottomUp;
    /// <summary>
    /// Valor da altura minima de acordo com as coordenadas da camera
    /// </summary>
    public float bottomDown;

    void Awake()
    {
        getWorldPosition();
    }

    /// <summary>
    /// Função que atribui os valores as variaveis de valor de altura;largura  Max?Min
    /// </summary>
    public void getWorldPosition()
    {
        //posição do produto escalar no pixel 0,0
        Vector3 _positionZero = Camera.main.ScreenToWorldPoint(new Vector3(0, 0));
        //posição do produto escalar no pixel maximo da camera
        Vector3 _positionMax = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));

        this.bottomLeft = _positionZero.x;
        this.bottomDown = _positionZero.y;

        this.bottomRight = _positionMax.x;
        this.bottomUp = _positionMax.y;
    }

}
