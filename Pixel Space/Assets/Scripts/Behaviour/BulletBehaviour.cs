﻿using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(0f, 10f * Time.deltaTime));
    }

    void checkEnds()
    {

    }
}