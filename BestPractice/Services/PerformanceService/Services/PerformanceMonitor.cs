using Grpc.Core;
using Performance;
using PerformanceService;

namespace PerformanceService.Services
{
	public class PerformanceMonitor : Performance.Monitor.MonitorBase
	{
		public override Task<PerformanceStatusResponse> GetPerformance(PerformanceStatusRequest request, ServerCallContext context)
		{
			var randomNumberGenerator = new Random();

			return Task.FromResult(new PerformanceStatusResponse
			{
				CpuPercentageUsage = randomNumberGenerator.NextDouble(),
				MemoryUsage = randomNumberGenerator.NextDouble() * 100,
				ProcessesRunning = randomNumberGenerator.Next(),
				ActiveConnections = randomNumberGenerator.Next()
			});
		}
	}
}