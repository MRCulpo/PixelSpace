using UnityEngine;
using System.Collections;
using System;

public class BulletOracleBehaviour : Bullet
{

    public Vector3 myScale = Vector3.zero;

    void OnEnable()
    {
        if (myScale == Vector3.zero)
            myScale = transform.localScale;

        transform.localScale = myScale;
        StartCoroutine(bulletCoroutine());
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }

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
        if (transform.position.y < CameraManager.instance.bottomUp || transform.position.y > CameraManager.instance.bottomDown ||
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
        yield return new WaitForSeconds(0.5f);

        gameObject.transform.localScale += gameObject.transform.localScale*0.15f;

        StartCoroutine(bulletCoroutine());
    }
}
