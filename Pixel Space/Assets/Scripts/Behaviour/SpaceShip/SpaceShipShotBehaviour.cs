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
    /// Referencia dos atributos das naves
    /// </summary>
    public SpaceShipAttributesBehaviour refSpaceShipAttributesBehaviour;

    /// <summary>
    /// Bala que vai ser criada
    /// </summary>
    private GameObject bullet;

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
             
                _bullet = LOManager.instance.LO_GetObjectDictionary(refSpaceShipAttributesBehaviour.refAttributesPower.bullet.name);

                if (_bullet == null)
                   _bullet = SpacePixelController.instance.createBullet(refSpaceShipAttributesBehaviour.refAttributesPower.bullet.name);

                _bullet.SetActive(true);

                if (_bullet.GetComponent<Bullet>())
                    _bullet.GetComponent<Bullet>().velocity = refSpaceShipAttributesBehaviour.refAttributesPower.velocity;

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
        yield return new WaitForSeconds(refSpaceShipAttributesBehaviour.refAttributesPower.timeToShot);
        this.isShot = true;
    }
}
