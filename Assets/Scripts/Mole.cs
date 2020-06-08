using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    [SerializeField] GameObject deathVFX;
    Score score;

    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    void OnMouseDown()
    {
        TriggerDeathVFX();
        Destroy(gameObject);
        score.AddToScore();
    }

    void TriggerDeathVFX()
    {
        if (!deathVFX){ return; }
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(deathVFXObject, 1f);
    }
}
