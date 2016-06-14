/*
Description Script:
Name:
Date:
Upgrade:
*/
using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        //Movimenta o objeto sempre em Y positivo
        transform.Translate(new Vector3(0f, 10f * Time.deltaTime));
        //verifica onde o objeto está para desliga-lo
        checkEnds();
    }

    /// <summary>
    /// verifica se a posição da bala está fora do quadro da tela
    /// </summary>

    void checkEnds()
    {
        if( transform.position.y < CameraManager.instance.bottomUp || transform.position.y > CameraManager.instance.bottomDown ||
            transform.position.x > CameraManager.instance.bottomRight || transform.position.x < CameraManager.instance.bottomLeft)
        {
            //desliga o objeto se ele estive fora da Screen do Usuario
            gameObject.SetActive(false);
        }
    }
}
