// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.TopologyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTopologicalRepresentationItem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTopologicalRepresentationItem : IIfcRepresentationItem
	{
	
	}
}

namespace Xbim.Ifc2x3.TopologyResource
{
	[ExpressType("IfcTopologicalRepresentationItem", 84)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcTopologicalRepresentationItem : IfcRepresentationItem, IIfcTopologicalRepresentationItem, IEquatable<@IfcTopologicalRepresentationItem>
	{
		#region IIfcTopologicalRepresentationItem explicit implementation
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTopologicalRepresentationItem(IModel model) : base(model) 		{ 
			Model = model; 
		}






		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTopologicalRepresentationItem other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTopologicalRepresentationItem
            var root = (@IfcTopologicalRepresentationItem)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTopologicalRepresentationItem left, @IfcTopologicalRepresentationItem right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTopologicalRepresentationItem left, @IfcTopologicalRepresentationItem right)
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