// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationDimensioningResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDimensionCurveTerminator
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDimensionCurveTerminator : IIfcTerminatorSymbol
	{
		IfcDimensionExtentUsage @Role { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[ExpressType("IfcDimensionCurveTerminator", 744)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDimensionCurveTerminator : IfcTerminatorSymbol, IInstantiableEntity, IIfcDimensionCurveTerminator, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcDimensionCurveTerminator>
	{
		#region IIfcDimensionCurveTerminator explicit implementation
		IfcDimensionExtentUsage IIfcDimensionCurveTerminator.Role { 
 
			get { return @Role; } 
			set { Role = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDimensionCurveTerminator(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDimensionExtentUsage _role;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 7)]
		public IfcDimensionExtentUsage @Role 
		{ 
			get 
			{
				if(_activated) return _role;
				Activate();
				return _role;
			} 
			set
			{
				SetValue( v =>  _role = v, _role, value,  "Role", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
                    _role = (IfcDimensionExtentUsage) System.Enum.Parse(typeof (IfcDimensionExtentUsage), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDimensionCurveTerminator other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Item != null)
					yield return @Item;
				foreach(var entity in @Styles)
					yield return entity;
				if (@AnnotatedCurve != null)
					yield return @AnnotatedCurve;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@Item != null)
					yield return @Item;
				if (@AnnotatedCurve != null)
					yield return @AnnotatedCurve;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}