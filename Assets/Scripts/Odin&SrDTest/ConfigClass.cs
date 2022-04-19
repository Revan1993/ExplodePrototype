using System;
using System.ComponentModel;
using DefaultNamespace.Odin_SrDTest.ConfigClasses;
using Sirenix.OdinInspector;
using UnityEngine;
namespace DefaultNamespace.Odin_SrDTest
{
    public class ConfigClass : SerializedMonoBehaviour
    {
        [SerializeField] private FirstConfig firstConfig;
        [SerializeField] private SecondClassWithProperties secondConfigWithFields;

        private SrdClass _srdClass = new SrdClass();
        private static ConfigClass instance;
        
        private void Awake()
        {
            instance = this;
            SRDebug.Instance?.AddOptionContainer(_srdClass);
        }

        public class SrdClass
        {
        
            [Button, Category("Config class")]
            public void CreateFirstConfig()
            {
                if (instance.firstConfig != null)
                {
                    SRDebug.Instance?.RemoveOptionContainer(instance.firstConfig);
                }
            
                instance.firstConfig = new FirstConfig();
                SRDebug.Instance?.AddOptionContainer(instance.firstConfig);
            }


            [Button, Category("Config class")]
            public void CreateSecondConfig()
            {
                if (instance.secondConfigWithFields != null)
                {
                    SRDebug.Instance?.RemoveOptionContainer(instance.secondConfigWithFields);
                    instance.secondConfigWithFields.Dispose();
                }
            
                instance.secondConfigWithFields = new SecondClassWithProperties();
                SRDebug.Instance?.AddOptionContainer(instance.secondConfigWithFields.Class);
                SRDebug.Instance?.AddOptionContainer(instance.secondConfigWithFields);
            }
        }
    }
}