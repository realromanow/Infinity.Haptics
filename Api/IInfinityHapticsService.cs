using Infinity.Haptics.Models;

namespace Infinity.Haptics.Api {
	public interface IInfinityHapticsService {
		void BeReadyToHaptics();

		void StopHapticEngine ();

		HapticModel GetDefaultHaptic ();
	}
}
