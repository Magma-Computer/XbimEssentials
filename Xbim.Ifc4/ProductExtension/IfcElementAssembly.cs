// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcElementAssembly
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcElementAssembly : IIfcElement
	{
		IfcAssemblyPlaceEnum? @AssemblyPlace { get;  set; }
		IfcElementAssemblyTypeEnum? @PredefinedType { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcElementAssembly", 18)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElementAssembly : IfcElement, IInstantiableEntity, IIfcElementAssembly, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcElementAssembly>
	{
		#region IIfcElementAssembly explicit implementation
		IfcAssemblyPlaceEnum? IIfcElementAssembly.AssemblyPlace { 
 
			get { return @AssemblyPlace; } 
			set { AssemblyPlace = value;}
		}	
		IfcElementAssemblyTypeEnum? IIfcElementAssembly.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementAssembly(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAssemblyPlaceEnum? _assemblyPlace;
		private IfcElementAssemblyTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 33)]
		public IfcAssemblyPlaceEnum? @AssemblyPlace 
		{ 
			get 
			{
				if(_activated) return _assemblyPlace;
				Activate();
				return _assemblyPlace;
			} 
			set
			{
				SetValue( v =>  _assemblyPlace = v, _assemblyPlace, value,  "AssemblyPlace", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 34)]
		public IfcElementAssemblyTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 10);
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
                    _assemblyPlace = (IfcAssemblyPlaceEnum) System.Enum.Parse(typeof (IfcAssemblyPlaceEnum), value.EnumVal, true);
					return;
				case 9: 
                    _predefinedType = (IfcElementAssemblyTypeEnum) System.Enum.Parse(typeof (IfcElementAssemblyTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcElementAssembly other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}