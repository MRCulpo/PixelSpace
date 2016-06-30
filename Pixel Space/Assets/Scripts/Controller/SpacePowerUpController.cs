using UnityEngine;
using System.Collections;

public class SpacePowerUpController : MonoBehaviour
{
    /// <summary>
    /// Ref dos PowersUps
    /// </summary>
    public GameObject[] powerUps;

    void Start()
    {
        StartCoroutine(shootPowerUp());
    }

    /// <summary>
    /// Criar Power Ups/ Testes
    /// </summary>
    void createPowerUp()
    {
        int _randomNumber = Random.Range(0, powerUps.Length);
        GameObject _obj = LOManager.instance.LO_GetObjectDictionaryToCreate(powerUps[_randomNumber].name, powerUps[_randomNumber]);

        if(_obj != null)
        {
            _obj.SetActive(true);

            float positionX = Random.Range(CameraManager.instance.bottomLeft + powerUps[_randomNumber].GetComponent<Renderer>().bounds.size.x,
                                            CameraManager.instance.bottomRight - powerUps[_randomNumber].GetComponent<Renderer>().bounds.size.x);
            float positionY = CameraManager.instance.bottomUp + powerUps[_randomNumber].GetComponent<Renderer>().bounds.size.y;

            _obj.transform.position = new Vector3(positionX, positionY);
        }
    }

    /// <summary>
    /// Disparador de PowerUps
    /// </summary>
    /// <returns></returns>
    IEnumerator shootPowerUp()
    {
        yield return new WaitForSeconds(Random.Range(2, 5));

        createPowerUp();

        StartCoroutine(shootPowerUp());
    }

}
