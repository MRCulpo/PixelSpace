/*
Description Script:
Name:
Date:
Upgrade:
*/
using UnityEngine;

[CreateAssetMenu(fileName = "Bullet", menuName = "Inventory/Bullet", order = 1)]
public class PowerBullet : ScriptableObject
{

    /// <summary>
    /// Tipo do enumerador para a bala
    /// </summary>
    public EnumPowerBullet typeBulletPower;

    /// <summary>
    /// Nome das Referencias aonde deve procurar
    /// </summary>
    public string[] refNamePosition;

    /// <summary>
    /// Referencia das posições de onde a bala vai sair
    /// </summary>
    [HideInInspector]
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
}
