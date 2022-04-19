using System;
using System.ComponentModel;
using Sirenix.OdinInspector;
using UnityEngine;
namespace DefaultNamespace.Odin_SrDTest.ConfigClasses
{
    [Serializable]
    public class FirstConfig
    {
        [Category("FirstConfig"), ShowInInspector]
        public string SomeString { get; set; }

        [Category("FirstConfig"), ShowInInspector]
        public bool BoolCheckboxField { get; set; }
        
        [Category("FirstConfig"), ShowInInspector]
        public Color Color { get; set; }

        [Category("FirstConfig"), ShowInInspector]
        [PropertyRange(1, 100), SROptions.NumberRangeAttribute(1, 100)]
        public int IntRangeField { get; set; }
        
        

    }
}