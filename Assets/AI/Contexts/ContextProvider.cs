//------------------------------------------------------------------------------
// <auto-generated>
// This class was auto generated by the Context Generator
// </auto-generated>
//------------------------------------------------------------------------------
namespace MyNamespace
{
    using System;
    using Apex.AI;
    using Apex.AI.Components;
    using UnityEngine;

    public class ContextProvider : MonoBehaviour, IContextProvider
    {
        private IAIContext _context;

        private void Awake()
        {
            _context = new PlayerContext(this.gameObject);
        }

        public IAIContext GetContext(Guid aiId)
        {
            return _context;
        }
    }
}