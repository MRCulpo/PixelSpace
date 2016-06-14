/*
Description Script:
Name:
Date:
Upgrade:
*/
using UnityEngine;
using System.Collections;

public class SpaceShipShotBehaviour : MonoBehaviour
{
    /// <summary>
    /// Bala que vai ser criada
    /// </summary>
    public GameObject bullet;
    /// <summary>
    /// Tempo do disparo entre as balas
    /// </summary>
    public float timeShot;
    /// <summary>
    /// Posições da onde vai sair a bala
    /// </summary>
    public Transform[] refShotPosition;


    /// <summary>
    /// Variavel para verificar se pode atirar
    /// </summary>
    private bool isShot;

    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        this.isShot = true;
    }

    /// <summary>
    /// Método que dispara os tiros das naves
    /// </summary>
    public void shot()
    {
        GameObject _bullet = null;

        if (this.isShot)
        {
            this.isShot = false;

            for(int i = 0; i < refShotPosition.Length; i++)
            {
                
                if (bullet.name.Equals("RedBullet"))
                    _bullet = LOManager.instance.LO_GetObjectDictionary("RedBullet");
                else if (bullet.name.Equals("BlueBullet"))
                    _bullet = LOManager.instance.LO_GetObjectDictionary("BlueBullet");

                if (_bullet == null)
                {
                    if (bullet.name.Equals("RedBullet"))
                        _bullet = SpacePixelController.instance.createBullet("RedBullet");
                    else if (bullet.name.Equals("BlueBullet"))
                        _bullet = SpacePixelController.instance.createBullet("BlueBullet");
                }

                _bullet.SetActive(true);

                _bullet.transform.position = this.refShotPosition[i].position;
                _bullet.transform.rotation = this.refShotPosition[i].rotation;
            }

            StartCoroutine(nextShot());
        }
    }

    /// <summary>
    /// Coroutine de contagem =P
    /// </summary>
    /// <returns></returns>
    IEnumerator nextShot()
    {
        yield return new WaitForSeconds(this.timeShot);
        this.isShot = true;
    }
}
