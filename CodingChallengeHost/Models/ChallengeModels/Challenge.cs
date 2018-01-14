using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallengeHost.Models.ChallengeModels
{
    public class Challenge
    {
        public int Id { get; set; }
        public DateTime Published { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
