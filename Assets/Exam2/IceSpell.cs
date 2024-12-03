using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    void Start()
    {
        Cast();
    }

    public override void Cast()
    {
        Cast("Ice Tomb Spell");
        Cast("Ice Tomb Spell", 4);
    }

}