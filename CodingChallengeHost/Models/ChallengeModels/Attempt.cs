using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallengeHost.Models.ChallengeModels
{
    public class Attempt
    {
        public Guid UserId { get; set; }
        public DateTime SubmissionReceived { get; set; }
    }
}
