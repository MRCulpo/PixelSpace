/*
Description Script:
Name:
Date:
Upgrade:
*/
using UnityEngine;


public enum StateGame
{
    Play,
    Pause,
    Over
}

public class SpacePixelController : Singleton<SpacePixelController>
{
    /// <summary>
    /// Os poderes que todas as naves podem ter para poder atirar
    /// </summary>
    public PowerBullet[] powers;

    /// <summary>
    /// Os Shields que as naves podem ter
    /// </summary>
    public Shield[] shields;

    /// <summary>
    /// Estado onde o jogo se encontra
    /// </summary>
    public StateGame stateGame { get; set; }

    /// </summary>
    void Start()
    {
        this.stateGame = StateGame.Play;

        for (int i = 0; i < powers.Length; i++)
            LOManager.instance.LO_createList(powers[i].bullet.name, powers[i].bullet, 5);
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
    /// Metodo para retornar o Escudo como parametro o tipo do Escudo
    /// </summary>
    /// <param name="_type"></param>
    /// <returns></returns>
    public Shield getShield(Shield.ShieldsType _type)
    {
        for (int i = 0; i < shields.Length; i++)
        {
            if (shields[i].shieldType.Equals(_type))
                return shields[i];
        }
        return null;
    }

    /// <summary>
    /// Metodo para retornar as configurações como parametro o tipo do "Bullet"
    /// </summary>
    /// <param name="_type"></param>
    /// <returns></returns>
    public PowerBullet getPowerBullet(PowerBullet.EnumPowerBullet _type)
    {
        for (int i = 0; i < powers.Length; i++)
        {
            if (powers[i].typeBulletPower.Equals(_type))
                return powers[i];
        }
        return null;
    }
}
