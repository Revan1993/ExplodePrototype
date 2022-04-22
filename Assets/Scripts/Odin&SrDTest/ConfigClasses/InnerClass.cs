using System;
using System.ComponentModel;
using Sirenix.OdinInspector;
using UnityEngine;
namespace DefaultNamespace.Odin_SrDTest.ConfigClasses
{
    [Serializable]
    public class InnerClass
    {
        [Category("Inner class"), ShowInInspector]
        public int FirstProperty { get; set; }
        
        [Category("Inner class"), ShowInInspector]
        public string SecondProperty { get; set; }

        [Category("Inner class"), ShowInInspector]
        public void SomeMethod()
        {
            Debug.LogError("Some method from inner class");
        }
        
        [Category("Inner class")]
        public int Argument { get; set; }
        
        [Category("Inner class")]
        public void MethodWithArguments()
        {
            Argument += 1;
            Debug.LogError($"Argument == {Argument}");
        }
    }
}