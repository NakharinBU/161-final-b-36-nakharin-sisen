using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private void Start()
    {
        base.Cast();
        Cast("Fire Pillar Spell", 5);
    }
}
