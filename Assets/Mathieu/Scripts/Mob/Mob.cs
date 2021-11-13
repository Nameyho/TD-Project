using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Mob : MonoBehaviour
{
    #region memberToBeHerited

    [SerializeField]
    protected string _mobName;

    [SerializeField]
    protected int _HealthPoint;

    [SerializeField]
    protected MobElement _mobElement; 

    #endregion

    #region Getter And Setter

    public string GetMobName()
    {
        return _mobName;
    }

    public void setMobName(string name)
    {
        _mobName = name;
    }

    public void setHealthPoint(int hp)
    {
        _HealthPoint = hp;
    }

    public int GetHealthPoint()
    {
        return _HealthPoint;
    }



    #endregion


}
