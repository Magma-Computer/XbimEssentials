// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSectionedSpine
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSectionedSpine : IIfcGeometricRepresentationItem
	{
		IIfcCompositeCurve @SpineCurve { get; }
		IEnumerable<IIfcProfileDef> @CrossSections { get; }
		IEnumerable<IIfcAxis2Placement3D> @CrossSectionPositions { get; }
		IfcDimensionCount @Dim  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcSectionedSpine", 300)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionedSpine : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcSectionedSpine, IEquatable<@IfcSectionedSpine>
	{
		#region IIfcSectionedSpine explicit implementation
		IIfcCompositeCurve IIfcSectionedSpine.SpineCurve { get { return @SpineCurve; } }	
		IEnumerable<IIfcProfileDef> IIfcSectionedSpine.CrossSections { get { return @CrossSections; } }	
		IEnumerable<IIfcAxis2Placement3D> IIfcSectionedSpine.CrossSectionPositions { get { return @CrossSectionPositions; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionedSpine(IModel model) : base(model) 		{ 
			Model = model; 
			_crossSections = new ItemSet<IfcProfileDef>( this, 0 );
			_crossSectionPositions = new ItemSet<IfcAxis2Placement3D>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcCompositeCurve _spineCurve;
		private ItemSet<IfcProfileDef> _crossSections;
		private ItemSet<IfcAxis2Placement3D> _crossSectionPositions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcCompositeCurve @SpineCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _spineCurve;
				((IPersistEntity)this).Activate(false);
				return _spineCurve;
			} 
			set
			{
				SetValue( v =>  _spineCurve = v, _spineCurve, value,  "SpineCurve");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1, 4)]
		public ItemSet<IfcProfileDef> @CrossSections 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _crossSections;
				((IPersistEntity)this).Activate(false);
				return _crossSections;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1, 5)]
		public ItemSet<IfcAxis2Placement3D> @CrossSectionPositions 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _crossSectionPositions;
				((IPersistEntity)this).Activate(false);
				return _crossSectionPositions;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return 3;
			    //##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_spineCurve = (IfcCompositeCurve)(value.EntityVal);
					return;
				case 1: 
					if (_crossSections == null) _crossSections = new ItemSet<IfcProfileDef>( this );
					_crossSections.InternalAdd((IfcProfileDef)value.EntityVal);
					return;
				case 2: 
					if (_crossSectionPositions == null) _crossSectionPositions = new ItemSet<IfcAxis2Placement3D>( this );
					_crossSectionPositions.InternalAdd((IfcAxis2Placement3D)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSectionedSpine other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSectionedSpine
            var root = (@IfcSectionedSpine)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSectionedSpine left, @IfcSectionedSpine right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSectionedSpine left, @IfcSectionedSpine right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}