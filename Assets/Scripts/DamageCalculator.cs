using System;

public class DamageCalculator
{
    public static int CalculateDamage(int amount, float mitigationPercent) => Convert.ToInt32(amount * mitigationPercent);
}
