using System;
namespace Ballers_API.Models
{
	public class Pitch
	{
		public bool IsNatural { get; set; }
		public string PitchType { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }

        public Pitch(PITCH_TYPE pitchType, string address, string note)
        {
            Address = address;
            Note = note;

            if (pitchType == PITCH_TYPE.NATURAL)
                IsNatural = true;
            else
                IsNatural = false;
        }
	}
	public enum PITCH_TYPE
	{
        NATURAL,
        ASTRO_TURF_2G,
        ASTRO_TURF_3G,
        ASTRO_TURF_4G,
        ASTRO_TURF_5G,
        ASTRO_TURF_6G,
    }

   
}