﻿using System;
namespace Ballers_API.Models
{
	public class Pitch
	{
		public bool IsNatural { get; set; }
		public string PitchType { get; set; }
        public string Address { get; set; }
        public int RecommendMaxPlayers{ get; set; }
        public string Description { get; set; }

        public Pitch(PITCH_TYPE pitchType, string address, string description)
        {
            Address = address;
            Description = description;

            IsNatural = false;
            if (pitchType == PITCH_TYPE.NATURAL)
                IsNatural = true;        
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