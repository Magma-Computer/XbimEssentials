// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.TopologyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFacetedBrepWithVoids
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFacetedBrepWithVoids : IIfcManifoldSolidBrep
	{
		IItemSet<IIfcClosedShell> @Voids { get; }
	
	}
}

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcFacetedBrepWithVoids", 369)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFacetedBrepWithVoids : IfcManifoldSolidBrep, IInstantiableEntity, IIfcFacetedBrepWithVoids, IContainsEntityReferences, IEquatable<@IfcFacetedBrepWithVoids>
	{
		#region IIfcFacetedBrepWithVoids explicit implementation
		IItemSet<IIfcClosedShell> IIfcFacetedBrepWithVoids.Voids { 
			get { return new Common.Collections.ProxyItemSet<IfcClosedShell, IIfcClosedShell>( @Voids); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFacetedBrepWithVoids(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_voids = new ItemSet<IfcClosedShell>( this, 0,  2);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcClosedShell> _voids;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IItemSet<IfcClosedShell> @Voids 
		{ 
			get 
			{
				if(_activated) return _voids;
				Activate();
				return _voids;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_voids.InternalAdd((IfcClosedShell)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFacetedBrepWithVoids other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Outer != null)
					yield return @Outer;
				foreach(var entity in @Voids)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}