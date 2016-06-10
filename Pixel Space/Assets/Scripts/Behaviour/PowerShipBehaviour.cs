using UnityEngine;
using System.Collections;

public class PowerShipBehaviour : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    public Power[] powers;
    /// <summary>
    /// 
    /// </summary>
    public SpriteRenderer shield;
    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        for (int i = 0; i < powers.Length; i++)
        {
            LOManager.instance.LO_createList(powers[i].bullet.name, powers[i].bullet, 5);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_ship"></param>
    /// <param name="_shotBehaviour"></param>
    public void chargePower(ref PowerShip _ship, SpaceShipShotBehaviour _shotBehaviour)
    {
        if(_ship == PowerShip.BluePower)
        {
            _ship = PowerShip.RedPower;
            Power _power = getPower(PowerShip.RedPower.ToString());

            this.shield.sprite = _power.shield;
            _shotBehaviour.bullet = _power.bullet;
        }
        else if(_ship == PowerShip.RedPower)
        {
            _ship = PowerShip.BluePower;
            Power _power = getPower(PowerShip.BluePower.ToString());

            this.shield.sprite = _power.shield;
            _shotBehaviour.bullet = _power.bullet;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_name"></param>
    /// <returns></returns
    public GameObject createBullet(string _name)
    {
        for (int i = 0; i < powers.Length; i++)
        {
            if (_name.Equals(powers[i].bullet.name))
                return LOManager.instance.LO_add(powers[i].bullet.name, powers[i].bullet);
        }
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_namePower"></param>
    /// <returns></returns>
    Power getPower(string _namePower)
    {
        print(_namePower);
        for (int i = 0; i < powers.Length; i++)
        {
            if (powers[i].namePower.Equals(_namePower))
                return powers[i];
        }
        return null;
    }

}
