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
}
