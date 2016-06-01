using UnityEngine;
using System.Collections;
using System;

public class SpaceShipBehaviour : MonoBehaviour
{
    /// <summary>
    /// Referencia do inputController
    /// </summary>
    public InputController inputController;

    /// <summary>
    /// referencia do gerenciamento de tiro
    /// </summary>
    public SpaceShipShotBehaviour shotBehaviour;

    /// <summary>
    /// Velocidade da espaçonave
    /// </summary>
    public float velocity;

    /// <summary>
    /// Velocidade em X e Y
    /// </summary>
    private float velocityX, velocityY;


    void OnEnable()
    {
        inputController.ev_rightControl_right += handleRCR;
        inputController.ev_rightControl_left += handleRCL;
        inputController.ev_rightControl_up += handleRCU;
        inputController.ev_rightControl_down += handleRCD;

        inputController.ev_leftControl_left += handleLCL;

    }



    void OnDisable()
    {
        inputController.ev_rightControl_right -= handleRCR;
        inputController.ev_rightControl_left -= handleRCL;
        inputController.ev_rightControl_up -= handleRCU;
        inputController.ev_rightControl_down -= handleRCD;

        inputController.ev_leftControl_left -= handleLCL;
    }


    /// <summary>
    /// Botão Esquerdo
    /// </summary>
    private void handleLCL()
    {
        print("Atirei");
        this.shotBehaviour.shot();
    }

    /// <summary>
    /// Botão Baixo
    /// </summary>
    private void handleRCD()
    {
        this.velocityY = -this.velocity;
        this.velocityX = 0;
        move(this.velocityX, this.velocityY);
    }

    /// <summary>
    /// Botão Esquerdo
    /// </summary>
    private void handleRCL()
    {
        this.velocityX = -this.velocity;
        this.velocityY = 0;
        move(this.velocityX, this.velocityY);
    }

    /// <summary>
    /// Botão Cima
    /// </summary>
    private void handleRCU()
    {
        this.velocityY = this.velocity;
        this.velocityX = 0;
        move(this.velocityX, this.velocityY);
    }


    /// <summary>
    /// Botão Direito
    /// </summary>
    private void handleRCR()
    {
        this.velocityX = this.velocity;
        this.velocityY = 0;
        move(this.velocityX, this.velocityY);
    }

    void move(float _velocityX, float _velocityY)
    {
        transform.Translate(_velocityX * Time.deltaTime , _velocityY * Time.deltaTime, 0f);
    }
}
