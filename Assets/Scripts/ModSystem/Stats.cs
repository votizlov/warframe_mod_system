using System;
using System.Collections;
using UnityEngine;

namespace ModSystem
{
    [CreateAssetMenu(fileName = "StatsData", menuName = "ScriptableObjects/Stats", order = 1)]
    public class Stats : ScriptableObject
    {
        [Serializable]
        public struct Stat
        {
            public StatName name;
            public float value;
            public StatType statType;
        }

        public enum StatName
        {
            BaseDmg,
            CritChance,
            CritMultiplier
        }

        public enum StatType
        {
            Additive,
            Percent
        }
        
        public Stat[] fields;

        /*public Stats(Hashtable fields)
        {
            this.fields = fields;
        }*/
    }
}