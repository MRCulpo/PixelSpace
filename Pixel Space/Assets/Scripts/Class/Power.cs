using UnityEngine;
using System.Collections;
/// <summary>
/// 
/// </summary>
public enum PowerShip
{
    RedPower,
    BluePower
}
/// <summary>
/// 
/// </summary>
[System.Serializable]
public class Power
{
    /// <summary>
    /// 
    /// </summary>
    public Sprite shield;
    /// <summary>
    /// 
    /// </summary>
    public GameObject bullet;
    /// <summary>
    /// 
    /// </summary>
    public string namePower;

    /// <summary>
    /// 
    /// </summary>
    public Power()
    {
        this.shield = null;
        this.bullet = null;
        this.namePower = "";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_shield"></param>
    /// <param name="_bullet"></param>
    /// <param name="_name"></param>
    public Power(Sprite _shield, GameObject _bullet, string _name)
    {
        this.shield = _shield;
        this.bullet = _bullet;
        this.namePower = _name;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_power"></param>
    public Power(Power _power)
    {
        this.shield = _power.shield;
        this.bullet = _power.bullet;
        this.namePower = _power.namePower;
    }
}
