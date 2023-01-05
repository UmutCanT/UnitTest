using System;

public class DamageCalculator
{
    public static int CalculateDamage(int amount, float mitigationPercent)
    {
        float multiplier = 1f - mitigationPercent;
        return Convert.ToInt32(amount * multiplier);
    }

    public static int CalculateDamage(int amount, Character character)
    {
        int totalArmor = character.Inventory.GetTotalArmor();
        float multiplier = totalArmor / 100f;
        return CalculateDamage(amount, multiplier);
    }

}
