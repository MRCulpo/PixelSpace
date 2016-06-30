using UnityEngine;
using System.Collections;
/// <summary>
/// Classe que contém o conteudo de tipo dos PowerUps
/// </summary>
public class PowerUpBehaviour : MonoBehaviour
{
    /// <summary>
    /// tipo do power
    /// </summary>
    public PowerBullet.EnumPowerBullet typePower;
    /// <summary>
    /// tamanho do objeto
    /// </summary>
    Vector3 boundSize;
    /// <summary>
    /// Velocidade do objeto
    /// </summary>
    [SerializeField]
    Vector2 velocity;

    void OnEnable()
    {
        boundSize = gameObject.GetComponent<Renderer>().bounds.size;
    }

    void Update()
    {

        move();

        checkEnds();
    }

    /// <summary>
    /// Verificar em qual posição está dentro da tela
    /// </summary>
    public void checkEnds()
    {
        if (transform.position.y + boundSize.y < CameraManager.instance.bottomDown ||
            transform.position.x - boundSize.x > CameraManager.instance.bottomRight || transform.position.x + boundSize.x < CameraManager.instance.bottomLeft)
        {
            //desliga o objeto se ele estive fora da Screen do Usuario
            gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Movimenta da Bala
    /// </summary>
    public void move()
    {
        //Movimenta o objeto sempre em Y positivo
        transform.Translate(new Vector3(velocity.x, velocity.y * Time.deltaTime));
    }

}
