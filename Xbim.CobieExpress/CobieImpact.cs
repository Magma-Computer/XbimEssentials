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
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;
//## Custom using statements
//##

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobieImpact
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieImpact : ICobieReferencedObject
	{
		string @Name { get;  set; }
		string @Description { get;  set; }
		ICobieImpactType @ImpactType { get;  set; }
		ICobieImpactStage @ImpactStage { get;  set; }
		double? @Value { get;  set; }
		ICobieImpactUnit @ImpactUnit { get;  set; }
		double? @LeadInTime { get;  set; }
		double? @Duration { get;  set; }
		double? @LeadOutTime { get;  set; }
		ICobieDurationUnit @DurationUnit { get;  set; }
		IEnumerable<ICobieAsset> @RelatedAssets {  get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Impact", 29)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieImpact : CobieReferencedObject, IInstantiableEntity, ICobieImpact, IContainsEntityReferences, IEquatable<@CobieImpact>
	{
		#region ICobieImpact explicit implementation
		string ICobieImpact.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		string ICobieImpact.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		ICobieImpactType ICobieImpact.ImpactType { 
 
 
			get { return @ImpactType; } 
			set { ImpactType = value as CobieImpactType;}
		}	
		ICobieImpactStage ICobieImpact.ImpactStage { 
 
 
			get { return @ImpactStage; } 
			set { ImpactStage = value as CobieImpactStage;}
		}	
		double? ICobieImpact.Value { 
 
			get { return @Value; } 
			set { Value = value;}
		}	
		ICobieImpactUnit ICobieImpact.ImpactUnit { 
 
 
			get { return @ImpactUnit; } 
			set { ImpactUnit = value as CobieImpactUnit;}
		}	
		double? ICobieImpact.LeadInTime { 
 
			get { return @LeadInTime; } 
			set { LeadInTime = value;}
		}	
		double? ICobieImpact.Duration { 
 
			get { return @Duration; } 
			set { Duration = value;}
		}	
		double? ICobieImpact.LeadOutTime { 
 
			get { return @LeadOutTime; } 
			set { LeadOutTime = value;}
		}	
		ICobieDurationUnit ICobieImpact.DurationUnit { 
 
 
			get { return @DurationUnit; } 
			set { DurationUnit = value as CobieDurationUnit;}
		}	
		 
		IEnumerable<ICobieAsset> ICobieImpact.RelatedAssets {  get { return @RelatedAssets; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieImpact(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobieImpactType _impactType;
		private CobieImpactStage _impactStage;
		private double? _value;
		private CobieImpactUnit _impactUnit;
		private double? _leadInTime;
		private double? _duration;
		private double? _leadOutTime;
		private CobieDurationUnit _durationUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public string @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public string @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public CobieImpactType @ImpactType 
		{ 
			get 
			{
				if(_activated) return _impactType;
				Activate();
				return _impactType;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _impactType = v, _impactType, value,  "ImpactType", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 9)]
		public CobieImpactStage @ImpactStage 
		{ 
			get 
			{
				if(_activated) return _impactStage;
				Activate();
				return _impactStage;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _impactStage = v, _impactStage, value,  "ImpactStage", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public double? @Value 
		{ 
			get 
			{
				if(_activated) return _value;
				Activate();
				return _value;
			} 
			set
			{
				SetValue( v =>  _value = v, _value, value,  "Value", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 11)]
		public CobieImpactUnit @ImpactUnit 
		{ 
			get 
			{
				if(_activated) return _impactUnit;
				Activate();
				return _impactUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _impactUnit = v, _impactUnit, value,  "ImpactUnit", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public double? @LeadInTime 
		{ 
			get 
			{
				if(_activated) return _leadInTime;
				Activate();
				return _leadInTime;
			} 
			set
			{
				SetValue( v =>  _leadInTime = v, _leadInTime, value,  "LeadInTime", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 13)]
		public double? @Duration 
		{ 
			get 
			{
				if(_activated) return _duration;
				Activate();
				return _duration;
			} 
			set
			{
				SetValue( v =>  _duration = v, _duration, value,  "Duration", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 14)]
		public double? @LeadOutTime 
		{ 
			get 
			{
				if(_activated) return _leadOutTime;
				Activate();
				return _leadOutTime;
			} 
			set
			{
				SetValue( v =>  _leadOutTime = v, _leadOutTime, value,  "LeadOutTime", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 15)]
		public CobieDurationUnit @DurationUnit 
		{ 
			get 
			{
				if(_activated) return _durationUnit;
				Activate();
				return _durationUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _durationUnit = v, _durationUnit, value,  "DurationUnit", 15);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Impacts")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { -1 }, new int [] { -1 }, 16)]
		public IEnumerable<CobieAsset> @RelatedAssets 
		{ 
			get 
			{
				return Model.Instances.Where<CobieAsset>(e => e.Impacts != null &&  e.Impacts.Contains(this), "Impacts", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_name = value.StringVal;
					return;
				case 6: 
					_description = value.StringVal;
					return;
				case 7: 
					_impactType = (CobieImpactType)(value.EntityVal);
					return;
				case 8: 
					_impactStage = (CobieImpactStage)(value.EntityVal);
					return;
				case 9: 
					_value = value.RealVal;
					return;
				case 10: 
					_impactUnit = (CobieImpactUnit)(value.EntityVal);
					return;
				case 11: 
					_leadInTime = value.RealVal;
					return;
				case 12: 
					_duration = value.RealVal;
					return;
				case 13: 
					_leadOutTime = value.RealVal;
					return;
				case 14: 
					_durationUnit = (CobieDurationUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieImpact other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Created != null)
					yield return @Created;
				if (@ExternalSystem != null)
					yield return @ExternalSystem;
				if (@ExternalObject != null)
					yield return @ExternalObject;
				if (@ImpactType != null)
					yield return @ImpactType;
				if (@ImpactStage != null)
					yield return @ImpactStage;
				if (@ImpactUnit != null)
					yield return @ImpactUnit;
				if (@DurationUnit != null)
					yield return @DurationUnit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}