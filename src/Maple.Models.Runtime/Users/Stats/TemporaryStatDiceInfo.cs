using System.Text.Json.Serialization;

namespace Maple.Models.Users.Stats;

/// <summary>
/// Persisted passive-skill-data bonuses applied by the dice buff.
/// Sourced from <c>PassiveSkillData</c> fields in <c>SecondaryStat::nDice_</c>/<c>rDice_</c> (PDB).
/// Readable member names are used here; legacy JSON keys are preserved via <see cref="JsonPropertyNameAttribute"/>.
/// Full field-to-key mapping is in <c>docs/runtime-temporary-stats.md</c>.
/// </summary>
public sealed class TemporaryStatDiceInfo
{
    /// <summary>Max HP rate bonus (<c>nMHPr</c>); JSON key <c>MHPr</c>.</summary>
    [JsonPropertyName("MHPr")]
    public int MaxHpRate { get; set; }

    /// <summary>Max MP rate bonus (<c>nMMPr</c>); JSON key <c>MMPr</c>.</summary>
    [JsonPropertyName("MMPr")]
    public int MaxMpRate { get; set; }

    /// <summary>Critical rate bonus % (<c>nCr</c>); JSON key <c>Cr</c>.</summary>
    [JsonPropertyName("Cr")]
    public int CriticalRate { get; set; }

    /// <summary>Minimum critical damage bonus % (<c>nCDMin</c>); JSON key <c>CDMin</c>.</summary>
    [JsonPropertyName("CDMin")]
    public int CriticalDamageMin { get; set; }

    /// <summary>Accuracy rate bonus % (<c>nACCr</c>); JSON key <c>ACCr</c>.</summary>
    [JsonPropertyName("ACCr")]
    public int AccuracyRate { get; set; }

    /// <summary>Evasion rate bonus % (<c>nEVAr</c>); JSON key <c>EVAr</c>.</summary>
    [JsonPropertyName("EVAr")]
    public int EvasionRate { get; set; }

    /// <summary>AR (attack-rate) bonus % (<c>nAr</c>); JSON key <c>Ar</c>.</summary>
    [JsonPropertyName("Ar")]
    public int ArRate { get; set; }

    /// <summary>ER (enemy-rate) bonus % (<c>nEr</c>); JSON key <c>Er</c>.</summary>
    [JsonPropertyName("Er")]
    public int ErRate { get; set; }

    /// <summary>Physical defense rate bonus % (<c>nPDDr</c>); JSON key <c>PDDr</c>.</summary>
    [JsonPropertyName("PDDr")]
    public int PhysicalDefenseRate { get; set; }

    /// <summary>Magic defense rate bonus % (<c>nMDDr</c>); JSON key <c>MDDr</c>.</summary>
    [JsonPropertyName("MDDr")]
    public int MagicDefenseRate { get; set; }

    /// <summary>Physical damage received reduction rate % (<c>nPDr</c>); JSON key <c>PDr</c>.</summary>
    [JsonPropertyName("PDr")]
    public int PhysicalDamageRate { get; set; }

    /// <summary>Magic damage received reduction rate % (<c>nMDr</c>); JSON key <c>MDr</c>.</summary>
    [JsonPropertyName("MDr")]
    public int MagicDamageRate { get; set; }

    /// <summary>Damage ignore PDR rate % (<c>nDIPr</c>); JSON key <c>DIPr</c>.</summary>
    [JsonPropertyName("DIPr")]
    public int IgnorePdrRate { get; set; }

    /// <summary>Physical damage dealt bonus % (<c>nPDamr</c>); JSON key <c>PDamr</c>.</summary>
    [JsonPropertyName("PDamr")]
    public int PhysicalDamageBonusRate { get; set; }

    /// <summary>Magic damage dealt bonus % (<c>nMDamr</c>); JSON key <c>MDamr</c>.</summary>
    [JsonPropertyName("MDamr")]
    public int MagicDamageBonusRate { get; set; }

    /// <summary>Physical attack rate bonus % (<c>nPADr</c>); JSON key <c>PADr</c>.</summary>
    [JsonPropertyName("PADr")]
    public int PhysicalAttackRate { get; set; }

    /// <summary>Magic attack rate bonus % (<c>nMADr</c>); JSON key <c>MADr</c>.</summary>
    [JsonPropertyName("MADr")]
    public int MagicAttackRate { get; set; }

    /// <summary>EXP gain rate bonus % (<c>nEXPr</c>); JSON key <c>EXPr</c>.</summary>
    [JsonPropertyName("EXPr")]
    public int ExperienceRate { get; set; }

    /// <summary>Ignore mob PDR rate % (<c>nIMPr</c>); JSON key <c>IMPr</c>.</summary>
    [JsonPropertyName("IMPr")]
    public int IgnoreMobPdrRate { get; set; }

    /// <summary>Abnormal-status resist rate % (<c>nASRr</c>); JSON key <c>ASRr</c>.</summary>
    [JsonPropertyName("ASRr")]
    public int AbnormalStatusResistRate { get; set; }

    /// <summary>Total elemental resist rate % (<c>nTERr</c>); JSON key <c>TERr</c>.</summary>
    [JsonPropertyName("TERr")]
    public int ElementalResistRate { get; set; }

    /// <summary>Meso drop rate bonus % (<c>nMESOr</c>); JSON key <c>MESOr</c>.</summary>
    [JsonPropertyName("MESOr")]
    public int MesoDropRate { get; set; }
}
