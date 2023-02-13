﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class JobsController : ControllerBase
	{
        private readonly IGrpcJobsClient client;
		public JobsController(IGrpcJobsClient client)
		{
			this.client = client;
		}

		[HttpPost("")]
		public void SendJobs([FromBody] IEnumerable<JobModel> jobs)
		{
			_ = client.SendJobs(jobs);
		}

		[HttpPost("{jobsCount}")]
		public void TriggerJobs(int jobsCount)
		{
			_ = client.TriggerJobs(jobsCount);
		}
	}
}
