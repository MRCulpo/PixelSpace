/*
Description Script:
Name:
Date:
Upgrade:
*/
using UnityEngine;
using System.Collections;
using System;

public class BulletDefaultBehaviour : Bullet
{
    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        //Movimenta o objeto
        move();
        //verifica onde o objeto está para desliga-lo
        checkEnds();
    }

    /// <summary>
    /// verifica se a posição da bala está fora do quadro da tela
    /// </summary>

    public override void checkEnds()
    {
        if (transform.position.y < CameraManager.instance.bottomDown || transform.position.y > CameraManager.instance.bottomUp ||
            transform.position.x > CameraManager.instance.bottomRight || transform.position.x < CameraManager.instance.bottomLeft)
        {
            //desliga o objeto se ele estive fora da Screen do Usuario
            gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Movimenta da Bala
    /// </summary>
    public override void move()
    {
        //Movimenta o objeto sempre em Y positivo
        transform.Translate(new Vector3(velocity.x, velocity.y * Time.deltaTime));
    }

    /// <summary>
    /// Metodo que contem implementação unica
    /// </summary>
    public override void bulletSpecial()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Metodo de uma coroutine se for necessario para usar
    /// </summary>
    /// <returns></returns>
    public override IEnumerator bulletCoroutine()
    {
        throw new NotImplementedException();
    }
}
