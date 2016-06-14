/*
Description Script:
Name:
Date:
Upgrade:
*/
using UnityEngine;

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
    /// referencia da SpaceShipAttributesBehaviour
    /// </summary>
    public SpaceShipAttributesBehaviour attributesBehaviour;

    /// <summary>
    /// Velocidade da espaçonave
    /// </summary>
    public float velocity;

    /// <summary>
    /// Velocidade em X e Y
    /// </summary>
    private float velocityX, velocityY;

    /// <summary>
    /// Enumerator verificar qual poder está utilizando
    /// </summary>
    private PowerShip powerShip;

    void Awake()
    {
        this.powerShip = PowerShip.BluePower;
    }

    /// <summary>
    /// 
    /// </summary>
    void OnEnable()
    {
        inputController.ev_rightControl_right += handleRCR;
        inputController.ev_rightControl_left += handleRCL;
        inputController.ev_rightControl_up += handleRCU;
        inputController.ev_rightControl_down += handleRCD;

        inputController.ev_leftControl_left += handleLCL;
        inputController.ev_leftControl_right_DOWN += handleLCRDown;

    }
    /// <summary>
    /// 
    /// </summary>
    void OnDisable()
    {
        inputController.ev_rightControl_right -= handleRCR;
        inputController.ev_rightControl_left -= handleRCL;
        inputController.ev_rightControl_up -= handleRCU;
        inputController.ev_rightControl_down -= handleRCD;

        inputController.ev_leftControl_left -= handleLCL;
        inputController.ev_leftControl_right_DOWN -= handleLCRDown;
    }


    /// <summary>
    /// Trocar Shield
    /// Direita --- Botão esquerdo
    /// </summary>
    private void handleLCRDown()
    {
        SpacePixelController.instance.chargePower(ref powerShip, this.shotBehaviour, this.attributesBehaviour.shield);
    }


    /// <summary>
    /// Atirar
    /// Direita --- Botão direitp
    /// </summary>
    private void handleLCL()
    {
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
