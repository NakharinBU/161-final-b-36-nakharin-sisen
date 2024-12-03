using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySpell : Spell
{
    private void Start()
    {
        Cast();
        ChainEffect();
    }

    public override void Cast()
    {
        Cast("Gravity Well Spell");
        Cast("Gravity Well Spell", 5);
    }

    // แสดงค่าเมื่อ Chain กับ Fire
    public void ChainEffect()
    {
        Debug.Log("Gravity Well, Chain with Fire Spell to call The Meteor");
    }

}
