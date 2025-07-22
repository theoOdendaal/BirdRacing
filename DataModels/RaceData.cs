using Microsoft.AspNetCore.Components.HtmlRendering.Infrastructure;

namespace BirdRacing.DataModels
{
    public class RaceData
    {
        public int Position { get; set; }
        public string RaceName { get; set; }
        public string RaceDate { get; set; }
        public string LoftName { get; set; }
        public string ClubId { get; set; }
        public int RingYear { get; set; }
        public string BirdId { get; set; }
        public string BirdColor { get; set; }
        public string BirdSex { get; set; }
        public DateTime TimeOfArrival { get; set; }
        public float Distance { get; set; }
        public float Velocity { get; set; }

        public RaceData()
        {
            RaceName = string.Empty;
            RaceDate = string.Empty;
            Position = 0;
            LoftName = string.Empty;
            ClubId = string.Empty;
            RingYear = 0;
            BirdId = string.Empty;
            BirdColor = string.Empty;
            BirdSex = string.Empty;
            TimeOfArrival = DateTime.MinValue;
            Distance = 0.0f;
            Velocity = 0.0f;
        }

        public RaceData(
            string raceName,
            string raceDate,
            int position,
            string loftName,
            string clubId,
            int ringYear,
            string birdId,
            string birdColor,
            string birdSex,
            DateTime timeOfArrival,
            float distance,
            float velocity)
        {
            RaceName = raceName;
            RaceDate = raceDate;
            Position = position;
            LoftName = loftName;
            ClubId = clubId;
            RingYear = ringYear;
            BirdId = birdId;
            BirdColor = birdColor;
            BirdSex = birdSex;
            TimeOfArrival = timeOfArrival;
            Distance = distance;
            Velocity = velocity;
        }

        public static implicit operator List<object>(RaceData v)
        {
            throw new NotImplementedException();
        }
    }
}