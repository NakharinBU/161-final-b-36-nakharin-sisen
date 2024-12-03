using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Spell-Casting Simulation Started");
    }

    public void Cast(string spellName)
    {
        Debug.Log($"Casting a {spellName}");
    }

    public void Cast(string spellName, int powerLevel)
    {
        Debug.Log($"Casting a {spellName} on target: Slime");
        Debug.Log("Casting a spell on target: Slime");

        Debug.Log($"Casting a spell on Slime with power level: {powerLevel}");
    }

}
