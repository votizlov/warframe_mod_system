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
            public string name;
            public float value;
            public StatType statType;
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