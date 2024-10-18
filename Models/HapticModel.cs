using Apple.CoreHaptics;

namespace Infinity.Haptics.Models {
	public class HapticModel {
		private readonly CHHapticPatternPlayer _patternPlayer;

		public HapticModel (CHHapticPatternPlayer patternPlayer) {
			_patternPlayer = patternPlayer;
		}

		public void Play () {
			_patternPlayer.Start();
		}
	}
}
