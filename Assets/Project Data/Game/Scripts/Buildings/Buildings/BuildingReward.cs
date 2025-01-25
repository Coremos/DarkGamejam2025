using UnityEngine;
using static Watermelon.Mission;

namespace Watermelon
{
    public class BuildingReward : BuildingBehavior
    {
        [BoxGroup("Reward", "Reward")]
        [SerializeField] protected MissionRewardType rewardType;
        public MissionRewardType RewardType => rewardType;

        [BoxGroup("Reward")]
        [SerializeField, ShowIf("SelectedRewardTypeIsResources")] protected ResourceRewardData resourceReward;
        public ResourceRewardData ResourceReward => resourceReward;

        [BoxGroup("Reward")]
        [SerializeField, ShowIf("SelectedRewardTypeIsTools")] protected ToolRewardData toolsReward;
        public ToolRewardData ToolsReward => toolsReward;

        [BoxGroup("Reward")]
        [SerializeField, ShowIf("SelectedRewardTypeIsGeneric")] protected GenericRewardData genericReward;
        public GenericRewardData GenericReward => genericReward;

        protected override void RegisterUpgrades()
        {

        }

        public override void FullyUnlock()
        {
            base.FullyUnlock();
            Debug.Log("FullyUnlock", gameObject);
            UnlockableToolsController.UnlockTool(toolsReward.InteractionToUnlock);
        }

        public override void SpawnUnlocked()
        {
            base.SpawnUnlocked();
            Debug.Log("SpawnUnlocked", gameObject);
        }
    }
}
