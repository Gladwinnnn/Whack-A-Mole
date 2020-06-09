using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] float waitToLoad = 1f;
    [SerializeField] GameObject winLabel;
    bool levelTimerFinished = false;

    void Start()
    {
        winLabel.SetActive(false);
    }

    void Update()
    {
        if (levelTimerFinished)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        yield return new WaitForSeconds(waitToLoad);
    }

    public void LeveltimerFinished()
    {
        levelTimerFinished = true;
        Time.timeScale = 0;
    }
}
