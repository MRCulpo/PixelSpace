using UnityEngine;
using System.Collections;

[System.Serializable]

public class Shield
{
    /// <summary>
    /// Enumarador dos tipos de escudos
    /// </summary>
    public enum ShieldsType
    {
        BLUE,
        RED
    }

    /// <summary>
    /// Tipo de Escudo que tem
    /// </summary>
    [SerializeField]
    private ShieldsType ShieldType;
    /// <summary>
    /// Referencia da Sprite 
    /// </summary>
    [SerializeField]
    private Sprite Sprite;

    /// <summary>
    /// Get/Set
    /// </summary>
    public ShieldsType shieldType
    {
        get
        {
            return ShieldType;
        }

        set
        {
            ShieldType = value;
        }
    }

    /// <summary>
    /// Get/Set
    /// </summary>
    public Sprite sprite
    {
        get
        {
            return Sprite;
        }

        set
        {
            Sprite = value;
        }
    }
    /// <summary>
    /// Metodo para trocar os valores do Shield
    /// </summary>
    /// <param name="_shield"></param>
    public void swapShield(Shield _shield)
    {
        ShieldType = _shield.shieldType;
        Sprite = _shield.sprite;
    }
}
