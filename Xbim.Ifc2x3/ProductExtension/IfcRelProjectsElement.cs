// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelProjectsElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelProjectsElement : IIfcRelConnects
	{
		IIfcElement @RelatingElement { get;  set; }
		IIfcFeatureElementAddition @RelatedFeatureElement { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IfcRelProjectsElement", 311)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelProjectsElement : IfcRelConnects, IInstantiableEntity, IIfcRelProjectsElement, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelProjectsElement>
	{
		#region IIfcRelProjectsElement explicit implementation
		IIfcElement IIfcRelProjectsElement.RelatingElement { 
 
 
			get { return @RelatingElement; } 
			set { RelatingElement = value as IfcElement;}
		}	
		IIfcFeatureElementAddition IIfcRelProjectsElement.RelatedFeatureElement { 
 
 
			get { return @RelatedFeatureElement; } 
			set { RelatedFeatureElement = value as IfcFeatureElementAddition;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelProjectsElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcElement _relatingElement;
		private IfcFeatureElementAddition _relatedFeatureElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcElement @RelatingElement 
		{ 
			get 
			{
				if(_activated) return _relatingElement;
				Activate();
				return _relatingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingElement = v, _relatingElement, value,  "RelatingElement", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcFeatureElementAddition @RelatedFeatureElement 
		{ 
			get 
			{
				if(_activated) return _relatedFeatureElement;
				Activate();
				return _relatedFeatureElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedFeatureElement = v, _relatedFeatureElement, value,  "RelatedFeatureElement", 6);
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
					_relatingElement = (IfcElement)(value.EntityVal);
					return;
				case 5: 
					_relatedFeatureElement = (IfcFeatureElementAddition)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelProjectsElement other)
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
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedFeatureElement != null)
					yield return @RelatedFeatureElement;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedFeatureElement != null)
					yield return @RelatedFeatureElement;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}