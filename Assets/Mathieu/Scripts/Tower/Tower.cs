using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    #region Exposed

    [SerializeField] 
    protected string _turretName;

    protected int _currentLevel;

    #endregion

    #region Methods

    public void SetTurretName(string turret)
    {
        _turretName = turret;
    }

    public string GetTurretName()
    {
        return _turretName;
    }

    public int GetCurrentLevel()
    {
        return _currentLevel;
    }

    public void SetCurrentLevel(int level)
    {
        _currentLevel = level;
    }

    #endregion
}
