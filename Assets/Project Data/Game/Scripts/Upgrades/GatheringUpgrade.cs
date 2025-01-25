using UnityEngine;
using Watermelon.GlobalUpgrades;
using System;
using UnityEditor;
using System.Linq;
using static Watermelon.AttackRangeUpgrade;

namespace Watermelon
{
    [CreateAssetMenu(fileName = "Gathering Upgrade", menuName = "Content/Upgrades/Gathering Upgrade")]
    public class GatheringUpgrade : GlobalUpgrade<GatheringUpgrade.GatheringUpgradeStage>
    {
        public override void Initialise()
        {
            upgrades = ReferenceTable.Upgrade.GetList()
                .Where(s => s.AbilityType1 == "AttackPower")
                .Select(s => GatheringUpgradeStage.Create(s.GoldCost, CurrencyType.Coins, null, s.AbilityAmount1)).ToArray();
        }

        public override string GetUpgradeDescription(int stageId)
        {
            try
            {
                var prevValue = GetStage(stageId).DamageMultiplier;
                var value = GetStage(stageId + 1).DamageMultiplier;

                return string.Format(DescriptionFormat, prevValue, value);
            }
            catch
            {
                return "";
            }
        }

        [System.Serializable]
        public class GatheringUpgradeStage : GlobalUpgradeStage
        {
            public static GatheringUpgradeStage Create(int price, CurrencyType currencyType, Sprite previewSprite, float value)
            {
                var stage = new GatheringUpgradeStage
                {
                    price = price,
                    currencyType = currencyType,
                    previewSprite = previewSprite,
                    damageMultiplier = value
                };

                return stage;
            }

            [SerializeField] float damageMultiplier = 1;
            public float DamageMultiplier => damageMultiplier;
        }
    }
}