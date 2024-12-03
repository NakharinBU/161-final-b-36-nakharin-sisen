using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{

    public virtual void Cast()
    {
        Debug.Log("Spell-Casting Simulation Started");
        Debug.Log("Casting a generic Spell");
    }

    public void Cast(string spellName)
    {
        Debug.Log($"Casting a {spellName}");
        Debug.Log($"Casting a on target: Slime");
    }

    public void Cast(string spellName, int powerLevel)
    {
        Debug.Log($"Casting a {spellName} on Slime with power level: {powerLevel}");
    }

}
