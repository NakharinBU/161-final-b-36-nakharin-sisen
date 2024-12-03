using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption;
    private float weight;

    private void Start()
    {
        dailyFoodConsumption = 0.4f;
        weight = 0.5f;


        Init("Bird");
        DisplayName();
        base.MakeSound();
        MakeSound();

        Debug.Log($"Bird eats {dailyFoodConsumption} kg per day and Bird's weighs {weight} kg");
        Debug.Log($"Bird's weekly food requirement: {CalculateFoodRequirement()}");
    }


    public override void MakeSound()
    {
        Debug.Log("Bird : Jip Jip");
    }

    public override float CalculateFoodRequirement()
    {
        return dailyFoodConsumption * weight * 7;
    }

}
