/*
Description Script:
Name:
Date:
Upgrade:
*/
using UnityEngine;
using System.Collections;
/// <summary>
/// 
/// </summary>
public class SpaceShipAttributesBehaviour : MonoBehaviour
{
    /// <summary>
    /// Shields que a nave tem
    /// </summary>
    public Shield refAttributesShield;
    /// <summary>
    /// Poder que a nave está 
    /// </summary>
    public PowerBullet refAttributesPower;
    /// <summary>
    /// Referencia da Sprite Render
    /// </summary>
    public SpriteRenderer shield;

    /// <summary>
    /// Metodo para fazer a troca de Shield
    /// </summary>
    public void swapShield()
    {
        if(refAttributesShield.shieldType.Equals(Shield.ShieldsType.BLUE))
        {
            refAttributesShield.swapShield(SpacePixelController.instance.getShield(Shield.ShieldsType.RED));
            shield.sprite = refAttributesShield.sprite;
        }
        else if (refAttributesShield.shieldType.Equals(Shield.ShieldsType.RED))
        {
            refAttributesShield.swapShield(SpacePixelController.instance.getShield(Shield.ShieldsType.BLUE));
            shield.sprite = refAttributesShield.sprite;
        }
    }
    /// <summary>
    /// Metodo para fazer a troca de PowerUp
    /// </summary>
    /// <param name="_type"></param>
    public void swapPower(PowerBullet.EnumPowerBullet _type)
    {
        refAttributesPower = SpacePixelController.instance.getPowerBullet(_type);
    }

    /// <summary>
    /// Colisão Trigger dentro do comportamento do Behaviour 
    /// *Power
    /// *Shield
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<PowerUpBehaviour>())
        {
            swapPower(other.GetComponent<PowerUpBehaviour>().typePower);
            other.gameObject.SetActive(false);
        }
    }
}
