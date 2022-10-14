using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stat", menuName = "Stat")]
public class Stat : ScriptableObject
{

    [Range(0,1000)]public int currentValue;


    public void ApplyStats(int value)
    {
        currentValue += value;
    }

}
