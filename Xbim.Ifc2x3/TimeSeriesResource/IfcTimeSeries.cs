// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ConstraintResource;
using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.TimeSeriesResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTimeSeries
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTimeSeries : IPersistEntity, IfcMetricValueSelect, IfcObjectReferenceSelect
	{
		IfcLabel @Name { get; }
		IfcText? @Description { get; }
		IIfcDateTimeSelect @StartTime { get; }
		IIfcDateTimeSelect @EndTime { get; }
		IfcTimeSeriesDataTypeEnum @TimeSeriesDataType { get; }
		IfcDataOriginEnum @DataOrigin { get; }
		IfcLabel? @UserDefinedDataOrigin { get; }
		IIfcUnit @Unit { get; }
		IEnumerable<IIfcTimeSeriesReferenceRelationship> @DocumentedBy {  get; }
	
	}
}

namespace Xbim.Ifc2x3.TimeSeriesResource
{
	[ExpressType("IfcTimeSeries", 418)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcTimeSeries : IPersistEntity, INotifyPropertyChanged, IIfcTimeSeries, IEquatable<@IfcTimeSeries>
	{
		#region IIfcTimeSeries explicit implementation
		IfcLabel IIfcTimeSeries.Name { get { return @Name; } }	
		IfcText? IIfcTimeSeries.Description { get { return @Description; } }	
		IIfcDateTimeSelect IIfcTimeSeries.StartTime { get { return @StartTime; } }	
		IIfcDateTimeSelect IIfcTimeSeries.EndTime { get { return @EndTime; } }	
		IfcTimeSeriesDataTypeEnum IIfcTimeSeries.TimeSeriesDataType { get { return @TimeSeriesDataType; } }	
		IfcDataOriginEnum IIfcTimeSeries.DataOrigin { get { return @DataOrigin; } }	
		IfcLabel? IIfcTimeSeries.UserDefinedDataOrigin { get { return @UserDefinedDataOrigin; } }	
		IIfcUnit IIfcTimeSeries.Unit { get { return @Unit; } }	
		 
		IEnumerable<IIfcTimeSeriesReferenceRelationship> IIfcTimeSeries.DocumentedBy {  get { return @DocumentedBy; } }
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTimeSeries(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcDateTimeSelect _startTime;
		private IfcDateTimeSelect _endTime;
		private IfcTimeSeriesDataTypeEnum _timeSeriesDataType;
		private IfcDataOriginEnum _dataOrigin;
		private IfcLabel? _userDefinedDataOrigin;
		private IfcUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcLabel @Name 
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
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcDateTimeSelect @StartTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _startTime;
				((IPersistEntity)this).Activate(false);
				return _startTime;
			} 
			set
			{
				SetValue( v =>  _startTime = v, _startTime, value,  "StartTime");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcDateTimeSelect @EndTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _endTime;
				((IPersistEntity)this).Activate(false);
				return _endTime;
			} 
			set
			{
				SetValue( v =>  _endTime = v, _endTime, value,  "EndTime");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 5)]
		public IfcTimeSeriesDataTypeEnum @TimeSeriesDataType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _timeSeriesDataType;
				((IPersistEntity)this).Activate(false);
				return _timeSeriesDataType;
			} 
			set
			{
				SetValue( v =>  _timeSeriesDataType = v, _timeSeriesDataType, value,  "TimeSeriesDataType");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 6)]
		public IfcDataOriginEnum @DataOrigin 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _dataOrigin;
				((IPersistEntity)this).Activate(false);
				return _dataOrigin;
			} 
			set
			{
				SetValue( v =>  _dataOrigin = v, _dataOrigin, value,  "DataOrigin");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcLabel? @UserDefinedDataOrigin 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedDataOrigin;
				((IPersistEntity)this).Activate(false);
				return _userDefinedDataOrigin;
			} 
			set
			{
				SetValue( v =>  _userDefinedDataOrigin = v, _userDefinedDataOrigin, value,  "UserDefinedDataOrigin");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unit;
				((IPersistEntity)this).Activate(false);
				return _unit;
			} 
			set
			{
				SetValue( v =>  _unit = v, _unit, value,  "Unit");
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ReferencedTimeSeries")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 9)]
		public IEnumerable<IfcTimeSeriesReferenceRelationship> @DocumentedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTimeSeriesReferenceRelationship>(e => e.ReferencedTimeSeries == this, "ReferencedTimeSeries", this);
			} 
		}
		#endregion

		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_startTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 3: 
					_endTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 4: 
                    _timeSeriesDataType = (IfcTimeSeriesDataTypeEnum) System.Enum.Parse(typeof (IfcTimeSeriesDataTypeEnum), value.EnumVal, true);
					return;
				case 5: 
                    _dataOrigin = (IfcDataOriginEnum) System.Enum.Parse(typeof (IfcDataOriginEnum), value.EnumVal, true);
					return;
				case 6: 
					_userDefinedDataOrigin = value.StringVal;
					return;
				case 7: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTimeSeries other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTimeSeries
            var root = (@IfcTimeSeries)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTimeSeries left, @IfcTimeSeries right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTimeSeries left, @IfcTimeSeries right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcTimeSeries left, IfcMetricValueSelect right)
		{
			return left == right as @IfcTimeSeries;
		}

		public static bool operator !=(@IfcTimeSeries left, IfcMetricValueSelect right)
		{
			return !(left == right);
		}

        public static bool operator ==(@IfcTimeSeries left, IfcObjectReferenceSelect right)
		{
			return left == right as @IfcTimeSeries;
		}

		public static bool operator !=(@IfcTimeSeries left, IfcObjectReferenceSelect right)
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