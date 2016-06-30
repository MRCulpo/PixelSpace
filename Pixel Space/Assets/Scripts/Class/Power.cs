/*
Description Script:
Name:
Date:
Upgrade:
*/
using UnityEngine;
using System.Collections;

[System.Serializable]
public class PowerBullet
{
    public enum EnumPowerBullet
    {
        DEFAULT,
        DAFAULTFOURSHOOT,
        DEFAULTTREESHOOT,
        ORACLE
    }

    /// <summary>
    /// Tipo do enumerador para a bala
    /// </summary>
    public EnumPowerBullet typeBulletPower;

    public Transform[] refPositionBullets;
    /// <summary>
    /// Referencia da Bala
    /// </summary>
    public GameObject bullet;

    /// <summary>
    /// Velocidade da bala
    /// </summary>
    public Vector2 velocity;

    /// <summary>
    /// Poder da Bala
    /// </summary>
    public int power;

    /// <summary>
    /// Tempo de cada disparo
    /// </summary>
    public float timeToShot;

    /// <summary>
    /// Construtor
    /// </summary>
    /// <param name="bullet"></param>
    /// <param name="velocity"></param>
    /// <param name="power"></param>
    /// <param name="timeToShot"></param>
    public PowerBullet(GameObject bullet, Vector2 velocity, int power, float timeToShot)
    {
        this.bullet = bullet;
        this.velocity = velocity;
        this.power = power;
        this.timeToShot = timeToShot;
    }
}
