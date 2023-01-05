using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculator
{
    public static int CalculateDamage(int amount, float mitigationPercent) => Convert.ToInt32(amount * mitigationPercent);
}
