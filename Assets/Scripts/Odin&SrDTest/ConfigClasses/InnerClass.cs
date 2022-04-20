using System;
using System.ComponentModel;
using Sirenix.OdinInspector;
using UnityEngine;
namespace DefaultNamespace.Odin_SrDTest.ConfigClasses
{
    [Serializable]
    public class InnerClass
    {
        [Category("Inner class"), SROptions.SortAttribute(3), ShowInInspector]
        public int FirstProperty { get; set; }
        
        [Category("Inner class"), SROptions.SortAttribute(3), ShowInInspector]
        public string SecondProperty { get; set; }

        [Category("Inner class"), SROptions.SortAttribute(2), ShowInInspector]
        public void SomeMethod()
        {
            Debug.LogError("Some method from inner class");
        }
        
        [Category("Inner class"), SROptions.SortAttribute(1)]
        public int Argument { get; set; }
        
        [Category("Inner class"), SROptions.SortAttribute(1)]
        public void MethodWithArguments()
        {
            Argument += 1;
            Debug.LogError($"Argument == {Argument}");
        }
    }
}