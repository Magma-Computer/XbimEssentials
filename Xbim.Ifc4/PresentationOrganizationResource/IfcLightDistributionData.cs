// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationOrganizationResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLightDistributionData
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLightDistributionData : IPersistEntity
	{
		IfcPlaneAngleMeasure @MainPlaneAngle { get;  set; }
		IItemSet<IfcPlaneAngleMeasure> @SecondaryPlaneAngle { get; }
		IItemSet<IfcLuminousIntensityDistributionMeasure> @LuminousIntensity { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationOrganizationResource
{
	[ExpressType("IfcLightDistributionData", 753)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightDistributionData : PersistEntity, IInstantiableEntity, IIfcLightDistributionData, IEquatable<@IfcLightDistributionData>
	{
		#region IIfcLightDistributionData explicit implementation
		IfcPlaneAngleMeasure IIfcLightDistributionData.MainPlaneAngle { 
 
			get { return @MainPlaneAngle; } 
			set { MainPlaneAngle = value;}
		}	
		IItemSet<IfcPlaneAngleMeasure> IIfcLightDistributionData.SecondaryPlaneAngle { 
			get { return @SecondaryPlaneAngle; } 
		}	
		IItemSet<IfcLuminousIntensityDistributionMeasure> IIfcLightDistributionData.LuminousIntensity { 
			get { return @LuminousIntensity; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightDistributionData(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_secondaryPlaneAngle = new ItemSet<IfcPlaneAngleMeasure>( this, 0,  2);
			_luminousIntensity = new ItemSet<IfcLuminousIntensityDistributionMeasure>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcPlaneAngleMeasure _mainPlaneAngle;
		private readonly ItemSet<IfcPlaneAngleMeasure> _secondaryPlaneAngle;
		private readonly ItemSet<IfcLuminousIntensityDistributionMeasure> _luminousIntensity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcPlaneAngleMeasure @MainPlaneAngle 
		{ 
			get 
			{
				if(_activated) return _mainPlaneAngle;
				Activate();
				return _mainPlaneAngle;
			} 
			set
			{
				SetValue( v =>  _mainPlaneAngle = v, _mainPlaneAngle, value,  "MainPlaneAngle", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 2)]
		public IItemSet<IfcPlaneAngleMeasure> @SecondaryPlaneAngle 
		{ 
			get 
			{
				if(_activated) return _secondaryPlaneAngle;
				Activate();
				return _secondaryPlaneAngle;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 3)]
		public IItemSet<IfcLuminousIntensityDistributionMeasure> @LuminousIntensity 
		{ 
			get 
			{
				if(_activated) return _luminousIntensity;
				Activate();
				return _luminousIntensity;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_mainPlaneAngle = value.RealVal;
					return;
				case 1: 
					_secondaryPlaneAngle.InternalAdd(value.RealVal);
					return;
				case 2: 
					_luminousIntensity.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLightDistributionData other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}