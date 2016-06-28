using System;
using System.Collections;
using UnityEngine;

public abstract class Bullet : MonoBehaviour , IBullet
{
    /// <summary>
    /// Velocidade da Bala
    /// </summary>
    private Vector2 Velocity;
    /// <summary>
    /// Poder Da Bala
    /// </summary>
    [SerializeField]private int Power;

    /// <summary>
    /// Get/set
    /// </summary>
    public Vector2 velocity
    {
        get
        {
            return Velocity;
        }

        set
        {
            Velocity = value;
        }
    }

    /// <summary>
    /// Get/set
    /// </summary>
    public int power
    {
        get
        {
            return Power;
        }

        set
        {
            Power = value;
        }
    }

    public abstract void checkEnds();
    public abstract void move();
    public abstract void bulletSpecial();
    public abstract IEnumerator bulletCoroutine();
}
