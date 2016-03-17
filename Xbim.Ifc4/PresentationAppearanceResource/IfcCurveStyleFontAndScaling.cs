// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurveStyleFontAndScaling
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurveStyleFontAndScaling : IIfcPresentationItem, IfcCurveFontOrScaledCurveFontSelect
	{
		IfcLabel? @Name { get; }
		IIfcCurveStyleFontSelect @CurveFont { get; }
		IfcPositiveRatioMeasure @CurveFontScaling { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcCurveStyleFontAndScaling", 569)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyleFontAndScaling : IfcPresentationItem, IInstantiableEntity, IIfcCurveStyleFontAndScaling, IEquatable<@IfcCurveStyleFontAndScaling>
	{
		#region IIfcCurveStyleFontAndScaling explicit implementation
		IfcLabel? IIfcCurveStyleFontAndScaling.Name { get { return @Name; } }	
		IIfcCurveStyleFontSelect IIfcCurveStyleFontAndScaling.CurveFont { get { return @CurveFont; } }	
		IfcPositiveRatioMeasure IIfcCurveStyleFontAndScaling.CurveFontScaling { get { return @CurveFontScaling; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyleFontAndScaling(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcCurveStyleFontSelect _curveFont;
		private IfcPositiveRatioMeasure _curveFontScaling;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcCurveStyleFontSelect @CurveFont 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveFont;
				((IPersistEntity)this).Activate(false);
				return _curveFont;
			} 
			set
			{
				SetValue( v =>  _curveFont = v, _curveFont, value,  "CurveFont");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcPositiveRatioMeasure @CurveFontScaling 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveFontScaling;
				((IPersistEntity)this).Activate(false);
				return _curveFontScaling;
			} 
			set
			{
				SetValue( v =>  _curveFontScaling = v, _curveFontScaling, value,  "CurveFontScaling");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_curveFont = (IfcCurveStyleFontSelect)(value.EntityVal);
					return;
				case 2: 
					_curveFontScaling = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurveStyleFontAndScaling other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCurveStyleFontAndScaling
            var root = (@IfcCurveStyleFontAndScaling)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCurveStyleFontAndScaling left, @IfcCurveStyleFontAndScaling right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCurveStyleFontAndScaling left, @IfcCurveStyleFontAndScaling right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcCurveStyleFontAndScaling left, IfcCurveFontOrScaledCurveFontSelect right)
		{
			return left == right as @IfcCurveStyleFontAndScaling;
		}

		public static bool operator !=(@IfcCurveStyleFontAndScaling left, IfcCurveFontOrScaledCurveFontSelect right)
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