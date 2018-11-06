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
using Xbim.Ifc2x3.ProfilePropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcReinforcementBarProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcReinforcementBarProperties : IPersistEntity
	{
		IfcAreaMeasure @TotalCrossSectionArea { get;  set; }
		IfcLabel @SteelGrade { get;  set; }
		IfcReinforcingBarSurfaceEnum? @BarSurface { get;  set; }
		IfcLengthMeasure? @EffectiveDepth { get;  set; }
		IfcPositiveLengthMeasure? @NominalBarDiameter { get;  set; }
		IfcCountMeasure? @BarCount { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IfcReinforcementBarProperties", 684)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcementBarProperties : PersistEntity, IInstantiableEntity, IIfcReinforcementBarProperties, IEquatable<@IfcReinforcementBarProperties>
	{
		#region IIfcReinforcementBarProperties explicit implementation
		IfcAreaMeasure IIfcReinforcementBarProperties.TotalCrossSectionArea { 
 
			get { return @TotalCrossSectionArea; } 
			set { TotalCrossSectionArea = value;}
		}	
		IfcLabel IIfcReinforcementBarProperties.SteelGrade { 
 
			get { return @SteelGrade; } 
			set { SteelGrade = value;}
		}	
		IfcReinforcingBarSurfaceEnum? IIfcReinforcementBarProperties.BarSurface { 
 
			get { return @BarSurface; } 
			set { BarSurface = value;}
		}	
		IfcLengthMeasure? IIfcReinforcementBarProperties.EffectiveDepth { 
 
			get { return @EffectiveDepth; } 
			set { EffectiveDepth = value;}
		}	
		IfcPositiveLengthMeasure? IIfcReinforcementBarProperties.NominalBarDiameter { 
 
			get { return @NominalBarDiameter; } 
			set { NominalBarDiameter = value;}
		}	
		IfcCountMeasure? IIfcReinforcementBarProperties.BarCount { 
 
			get { return @BarCount; } 
			set { BarCount = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcementBarProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAreaMeasure _totalCrossSectionArea;
		private IfcLabel _steelGrade;
		private IfcReinforcingBarSurfaceEnum? _barSurface;
		private IfcLengthMeasure? _effectiveDepth;
		private IfcPositiveLengthMeasure? _nominalBarDiameter;
		private IfcCountMeasure? _barCount;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcAreaMeasure @TotalCrossSectionArea 
		{ 
			get 
			{
				if(_activated) return _totalCrossSectionArea;
				Activate();
				return _totalCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _totalCrossSectionArea = v, _totalCrossSectionArea, value,  "TotalCrossSectionArea", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLabel @SteelGrade 
		{ 
			get 
			{
				if(_activated) return _steelGrade;
				Activate();
				return _steelGrade;
			} 
			set
			{
				SetValue( v =>  _steelGrade = v, _steelGrade, value,  "SteelGrade", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 3)]
		public IfcReinforcingBarSurfaceEnum? @BarSurface 
		{ 
			get 
			{
				if(_activated) return _barSurface;
				Activate();
				return _barSurface;
			} 
			set
			{
				SetValue( v =>  _barSurface = v, _barSurface, value,  "BarSurface", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLengthMeasure? @EffectiveDepth 
		{ 
			get 
			{
				if(_activated) return _effectiveDepth;
				Activate();
				return _effectiveDepth;
			} 
			set
			{
				SetValue( v =>  _effectiveDepth = v, _effectiveDepth, value,  "EffectiveDepth", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcPositiveLengthMeasure? @NominalBarDiameter 
		{ 
			get 
			{
				if(_activated) return _nominalBarDiameter;
				Activate();
				return _nominalBarDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalBarDiameter = v, _nominalBarDiameter, value,  "NominalBarDiameter", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcCountMeasure? @BarCount 
		{ 
			get 
			{
				if(_activated) return _barCount;
				Activate();
				return _barCount;
			} 
			set
			{
				SetValue( v =>  _barCount = v, _barCount, value,  "BarCount", 6);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_totalCrossSectionArea = value.RealVal;
					return;
				case 1: 
					_steelGrade = value.StringVal;
					return;
				case 2: 
                    _barSurface = (IfcReinforcingBarSurfaceEnum) System.Enum.Parse(typeof (IfcReinforcingBarSurfaceEnum), value.EnumVal, true);
					return;
				case 3: 
					_effectiveDepth = value.RealVal;
					return;
				case 4: 
					_nominalBarDiameter = value.RealVal;
					return;
				case 5: 
					_barCount = value.NumberVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcementBarProperties other)
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