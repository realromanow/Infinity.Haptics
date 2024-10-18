using Apple.CoreHaptics;
using Infinity.Haptics.Api;
using Infinity.Haptics.Models;
using System.Collections.Generic;

namespace Infinity.Haptics.App {
	public class InfinityHapticsService : IInfinityHapticsService {
		private readonly CHHapticEngine _chHapticEngine;

		public InfinityHapticsService () {
			_chHapticEngine = new CHHapticEngine();
		}

		public void BeReadyToHaptics () {
			_chHapticEngine.Start();
		}

		public void StopHapticEngine () {
			_chHapticEngine.Stop();
		}

		public HapticModel GetDefaultHaptic () {
			var hapticPattern = new CHHapticPattern(new List<CHHapticEvent>() {
				new() {
					EventType = CHHapticEventType.HapticTransient,
					Time = 0,
					EventDuration = 0.5f,
				},
			});

			var player = _chHapticEngine.MakePlayer(hapticPattern);

			return new HapticModel(player);
		}
	}
}
