using Infinity.Haptics.App;
using Plugins.Infinity.DI.App;
using Plugins.Infinity.DI.Units;
using UnityEngine;

namespace Infinity.Haptics.Units {
	[CreateAssetMenu(menuName = "Infinity/Units/InfinityHaptics", fileName = "InfinityHaptics")]
	public class InfinityHapticsUnit : AppUnit {
		public override void SetupUnit (AppComponentsRegistry componentsRegistry) {
			base.SetupUnit(componentsRegistry);

			componentsRegistry.Instantiate<InfinityHapticsService>();
		}
		
	}
}
