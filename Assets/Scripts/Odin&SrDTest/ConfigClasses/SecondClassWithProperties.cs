using System;
using System.ComponentModel;
using UnityEngine;
namespace DefaultNamespace.Odin_SrDTest.ConfigClasses
{
    [Serializable]
    public class SecondClassWithProperties : IDisposable
    {
        [Category("Second")]
        [SROptions.NumberRangeAttribute(1, 100)]
        public int IntProperty { get; set; }
        
        public InnerClass Class = new InnerClass();
        
        [SROptions.SrIgnore]
        public void Dispose()
        {
            SRDebug.Instance?.RemoveOptionContainer(Class);    
        }
    }
}