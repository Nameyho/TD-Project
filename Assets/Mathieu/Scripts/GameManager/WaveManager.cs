using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    #region Privates Member

    private int _currentWave;

    private int _mobSpawnCount;

    private bool _mustWaveStart;

    #endregion

    #region Exposed
    
    [Header("Configuration de la vague")]
    [SerializeField]
    private int _baseWaveNumber;

    [SerializeField]
    private float _gainOverWaves;

    [SerializeField]
    private float _delayBetweenMobSpawn;


    [SerializeField]
    private Transform[] _spawnerLocation;


    [Header("Configuration des vague d'ennemis")]
    [SerializeField]
    private GameObject[] _mobArray;
 
    #endregion

    #region privates methods

    IEnumerator StartNewWave()
    {
        while(_mobSpawnCount<=_baseWaveNumber)
        {
            int spawnRandom = Random.Range(0, _spawnerLocation.Length);
            int mobRandom = Random.Range(0, _mobArray.Length);
            Instantiate(_mobArray[mobRandom], _spawnerLocation[spawnRandom]);
            _mobSpawnCount++;
            yield return new WaitForSeconds(_delayBetweenMobSpawn);
        }
    }

    #endregion

    #region Unity API


    private void Update()
    {
        if (_mustWaveStart)
        {
            StartCoroutine(StartNewWave());
            _mustWaveStart = false;
        }

    }
    #endregion


    #region public Methods

    public void StartWave()
    {
        if (!_mustWaveStart)
        {
            _mustWaveStart = true;
            _mobSpawnCount = 0;
        }
    }

    #endregion
}
