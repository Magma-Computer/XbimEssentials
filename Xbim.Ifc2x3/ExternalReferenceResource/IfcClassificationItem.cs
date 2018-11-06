// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ExternalReferenceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcClassificationItem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcClassificationItem : IPersistEntity
	{
		IIfcClassificationNotationFacet @Notation { get;  set; }
		IIfcClassification @ItemOf { get;  set; }
		IfcLabel @Title { get;  set; }
		IEnumerable<IIfcClassificationItemRelationship> @IsClassifiedItemIn {  get; }
		IEnumerable<IIfcClassificationItemRelationship> @IsClassifyingItemIn {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[ExpressType("IfcClassificationItem", 14)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassificationItem : PersistEntity, IInstantiableEntity, IIfcClassificationItem, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcClassificationItem>
	{
		#region IIfcClassificationItem explicit implementation
		IIfcClassificationNotationFacet IIfcClassificationItem.Notation { 
 
 
			get { return @Notation; } 
			set { Notation = value as IfcClassificationNotationFacet;}
		}	
		IIfcClassification IIfcClassificationItem.ItemOf { 
 
 
			get { return @ItemOf; } 
			set { ItemOf = value as IfcClassification;}
		}	
		IfcLabel IIfcClassificationItem.Title { 
 
			get { return @Title; } 
			set { Title = value;}
		}	
		 
		IEnumerable<IIfcClassificationItemRelationship> IIfcClassificationItem.IsClassifiedItemIn {  get { return @IsClassifiedItemIn; } }
		IEnumerable<IIfcClassificationItemRelationship> IIfcClassificationItem.IsClassifyingItemIn {  get { return @IsClassifyingItemIn; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcClassificationItem(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcClassificationNotationFacet _notation;
		private IfcClassification _itemOf;
		private IfcLabel _title;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcClassificationNotationFacet @Notation 
		{ 
			get 
			{
				if(_activated) return _notation;
				Activate();
				return _notation;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _notation = v, _notation, value,  "Notation", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcClassification @ItemOf 
		{ 
			get 
			{
				if(_activated) return _itemOf;
				Activate();
				return _itemOf;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _itemOf = v, _itemOf, value,  "ItemOf", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLabel @Title 
		{ 
			get 
			{
				if(_activated) return _title;
				Activate();
				return _title;
			} 
			set
			{
				SetValue( v =>  _title = v, _title, value,  "Title", 3);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedItems")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 4)]
		public IEnumerable<IfcClassificationItemRelationship> @IsClassifiedItemIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationItemRelationship>(e => e.RelatedItems != null &&  e.RelatedItems.Contains(this), "RelatedItems", this);
			} 
		}
		[InverseProperty("RelatingItem")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 5)]
		public IEnumerable<IfcClassificationItemRelationship> @IsClassifyingItemIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationItemRelationship>(e => Equals(e.RelatingItem), "RelatingItem", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_notation = (IfcClassificationNotationFacet)(value.EntityVal);
					return;
				case 1: 
					_itemOf = (IfcClassification)(value.EntityVal);
					return;
				case 2: 
					_title = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcClassificationItem other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Notation != null)
					yield return @Notation;
				if (@ItemOf != null)
					yield return @ItemOf;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ItemOf != null)
					yield return @ItemOf;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}