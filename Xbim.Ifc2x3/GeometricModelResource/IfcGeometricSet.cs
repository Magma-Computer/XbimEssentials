// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
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
    /// Readonly interface for IfcGeometricSet
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGeometricSet : IIfcGeometricRepresentationItem
	{
		IItemSet<IIfcGeometricSetSelect> @Elements { get; }
		IfcDimensionCount @Dim  { get ; }
	
	}
}

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcGeometricSet", 236)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeometricSet : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcGeometricSet, IContainsEntityReferences, IEquatable<@IfcGeometricSet>
	{
		#region IIfcGeometricSet explicit implementation
		IItemSet<IIfcGeometricSetSelect> IIfcGeometricSet.Elements { 
			get { return new Common.Collections.ProxyItemSet<IfcGeometricSetSelect, IIfcGeometricSetSelect>( @Elements); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricSet(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_elements = new ItemSet<IfcGeometricSetSelect>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcGeometricSetSelect> _elements;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 3)]
		public IItemSet<IfcGeometricSetSelect> @Elements 
		{ 
			get 
			{
				if(_activated) return _elements;
				Activate();
				return _elements;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return Elements != null
			        ? Elements[0].Dim
			        : 0;
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_elements.InternalAdd((IfcGeometricSetSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGeometricSet other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Elements)
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