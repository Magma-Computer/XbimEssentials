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
    /// Readonly interface for IfcTextureVertex
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextureVertex : IIfcPresentationItem
	{
		IEnumerable<IfcParameterValue> @Coordinates { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcTextureVertex", 735)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureVertex : IfcPresentationItem, IInstantiableEntity, IIfcTextureVertex, IEquatable<@IfcTextureVertex>
	{
		#region IIfcTextureVertex explicit implementation
		IEnumerable<IfcParameterValue> IIfcTextureVertex.Coordinates { get { return @Coordinates; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureVertex(IModel model) : base(model) 		{ 
			Model = model; 
			_coordinates = new ItemSet<IfcParameterValue>( this, 2 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcParameterValue> _coordinates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, 2, 1)]
		public ItemSet<IfcParameterValue> @Coordinates 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coordinates;
				((IPersistEntity)this).Activate(false);
				return _coordinates;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_coordinates == null) _coordinates = new ItemSet<IfcParameterValue>( this );
					_coordinates.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextureVertex other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextureVertex
            var root = (@IfcTextureVertex)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextureVertex left, @IfcTextureVertex right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextureVertex left, @IfcTextureVertex right)
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