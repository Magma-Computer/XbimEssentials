// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurveStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurveStyle : IIfcPresentationStyle, IfcPresentationStyleSelect
	{
		IIfcCurveFontOrScaledCurveFontSelect @CurveFont { get;  set; }
		IIfcSizeSelect @CurveWidth { get;  set; }
		IIfcColour @CurveColour { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcCurveStyle", 118)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyle : IfcPresentationStyle, IInstantiableEntity, IIfcCurveStyle, IContainsEntityReferences, IEquatable<@IfcCurveStyle>
	{
		#region IIfcCurveStyle explicit implementation
		IIfcCurveFontOrScaledCurveFontSelect IIfcCurveStyle.CurveFont { 
 
 
			get { return @CurveFont; } 
			set { CurveFont = value as IfcCurveFontOrScaledCurveFontSelect;}
		}	
		IIfcSizeSelect IIfcCurveStyle.CurveWidth { 
 
 
			get { return @CurveWidth; } 
			set { CurveWidth = value as IfcSizeSelect;}
		}	
		IIfcColour IIfcCurveStyle.CurveColour { 
 
 
			get { return @CurveColour; } 
			set { CurveColour = value as IfcColour;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyle(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCurveFontOrScaledCurveFontSelect _curveFont;
		private IfcSizeSelect _curveWidth;
		private IfcColour _curveColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcCurveFontOrScaledCurveFontSelect @CurveFont 
		{ 
			get 
			{
				if(_activated) return _curveFont;
				Activate();
				return _curveFont;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _curveFont = v, _curveFont, value,  "CurveFont", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcSizeSelect @CurveWidth 
		{ 
			get 
			{
				if(_activated) return _curveWidth;
				Activate();
				return _curveWidth;
			} 
			set
			{
				SetValue( v =>  _curveWidth = v, _curveWidth, value,  "CurveWidth", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcColour @CurveColour 
		{ 
			get 
			{
				if(_activated) return _curveColour;
				Activate();
				return _curveColour;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _curveColour = v, _curveColour, value,  "CurveColour", 4);
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
					_curveFont = (IfcCurveFontOrScaledCurveFontSelect)(value.EntityVal);
					return;
				case 2: 
					_curveWidth = (IfcSizeSelect)(value.EntityVal);
					return;
				case 3: 
					_curveColour = (IfcColour)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurveStyle other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@CurveFont != null)
					yield return @CurveFont;
				if (@CurveColour != null)
					yield return @CurveColour;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}