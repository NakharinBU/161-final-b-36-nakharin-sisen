using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption;
    private int activityLevel;

    private void Start()
    {
        dailyFoodConsumption = 1f;
        activityLevel = 4;

        Init("Dog");
        DisplayName();
        base.MakeSound();
        MakeSound();

        Debug.Log($"Dog eats {dailyFoodConsumption} kg per day with activity level {activityLevel}");
        Debug.Log($"Dog's weekly food requirement: {CalculateFoodRequirement()}");
    }

    public override void MakeSound()
    {
        Debug.Log("Dog : Hong Hong");
    }


    public override float CalculateFoodRequirement()
    {
        return dailyFoodConsumption * activityLevel * 7;
    }
}
