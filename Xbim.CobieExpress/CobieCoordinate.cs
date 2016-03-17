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
    /// Readonly interface for CobieCoordinate
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieCoordinate : ICobieReferencedObject
	{
		string @Name { get; }
		CoordinateTypeEnum? @CoordinateType { get; }
		double @X { get; }
		double @Y { get; }
		double @Z { get; }
		double? @RotationX { get; }
		double? @RotationY { get; }
		double? @RotationZ { get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Coordinate", 33)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieCoordinate : CobieReferencedObject, IInstantiableEntity, ICobieCoordinate, IEquatable<@CobieCoordinate>
	{
		#region ICobieCoordinate explicit implementation
		string ICobieCoordinate.Name { get { return @Name; } }	
		CoordinateTypeEnum? ICobieCoordinate.CoordinateType { get { return @CoordinateType; } }	
		double ICobieCoordinate.X { get { return @X; } }	
		double ICobieCoordinate.Y { get { return @Y; } }	
		double ICobieCoordinate.Z { get { return @Z; } }	
		double? ICobieCoordinate.RotationX { get { return @RotationX; } }	
		double? ICobieCoordinate.RotationY { get { return @RotationY; } }	
		double? ICobieCoordinate.RotationZ { get { return @RotationZ; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieCoordinate(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _name;
		private CoordinateTypeEnum? _coordinateType;
		private double _x;
		private double _y;
		private double _z;
		private double? _rotationX;
		private double? _rotationY;
		private double? _rotationZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public string @Name 
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
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 7)]
		public CoordinateTypeEnum? @CoordinateType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coordinateType;
				((IPersistEntity)this).Activate(false);
				return _coordinateType;
			} 
			set
			{
				SetValue( v =>  _coordinateType = v, _coordinateType, value,  "CoordinateType");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public double @X 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _x;
				((IPersistEntity)this).Activate(false);
				return _x;
			} 
			set
			{
				SetValue( v =>  _x = v, _x, value,  "X");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public double @Y 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _y;
				((IPersistEntity)this).Activate(false);
				return _y;
			} 
			set
			{
				SetValue( v =>  _y = v, _y, value,  "Y");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public double @Z 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _z;
				((IPersistEntity)this).Activate(false);
				return _z;
			} 
			set
			{
				SetValue( v =>  _z = v, _z, value,  "Z");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public double? @RotationX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationX;
				((IPersistEntity)this).Activate(false);
				return _rotationX;
			} 
			set
			{
				SetValue( v =>  _rotationX = v, _rotationX, value,  "RotationX");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public double? @RotationY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationY;
				((IPersistEntity)this).Activate(false);
				return _rotationY;
			} 
			set
			{
				SetValue( v =>  _rotationY = v, _rotationY, value,  "RotationY");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public double? @RotationZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationZ;
				((IPersistEntity)this).Activate(false);
				return _rotationZ;
			} 
			set
			{
				SetValue( v =>  _rotationZ = v, _rotationZ, value,  "RotationZ");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
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
                    _coordinateType = (CoordinateTypeEnum) System.Enum.Parse(typeof (CoordinateTypeEnum), value.EnumVal, true);
					return;
				case 7: 
					_x = value.RealVal;
					return;
				case 8: 
					_y = value.RealVal;
					return;
				case 9: 
					_z = value.RealVal;
					return;
				case 10: 
					_rotationX = value.RealVal;
					return;
				case 11: 
					_rotationY = value.RealVal;
					return;
				case 12: 
					_rotationZ = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieCoordinate other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieCoordinate
            var root = (@CobieCoordinate)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieCoordinate left, @CobieCoordinate right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieCoordinate left, @CobieCoordinate right)
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